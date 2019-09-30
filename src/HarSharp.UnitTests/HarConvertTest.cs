using System;
using NUnit.Framework;

namespace HarSharp.UnitTests
{
    [TestFixture]
    public class HarConvertTest
    {
        private Har m_actual;

        [SetUp]
        public void InitializeFixture()
        {
            m_actual = HarConvert.DeserializeFromFile(@"Hars\Sample.har");
        }

        [Test]
        public void Deserialize_Null_Exception()
        {
            Assert.Catch<ArgumentNullException>(() => HarConvert.Deserialize(null));
        }

        [Test]
        public void Deserialize_HarContent_Log()
        {
            var log = m_actual.Log;
            Assert.AreEqual("1.2", log.Version);

            var creator = log.Creator;
            Assert.AreEqual("WebInspector", creator.Name);
            Assert.AreEqual("537.36", creator.Version);

            var browser = log.Browser;
            Assert.IsNull(browser);

            var pages = log.Pages;

            Assert.AreEqual(3, pages.Count);

            Assert.AreEqual("used by unit test", log.Comment);
        }

        [Test]
        public void Deserialize_HarContent_Creator()
        {
            var creator = m_actual.Log.Creator;
            Assert.AreEqual("WebInspector", creator.Name);
            Assert.AreEqual("537.36", creator.Version);
        }

        [Test]
        public void Deserialize_HarContent_Browser()
        {
            var browser = m_actual.Log.Browser;
            Assert.IsNull(browser);
        }

        [Test]
        public void Deserialize_HarContent_Pages()
        {
            var pages = m_actual.Log.Pages;
            Assert.AreEqual(3, pages.Count);

            var page = pages[0];
            Assert.AreEqual(new DateTime(2014, 9, 24, 18, 39, 52, 160, DateTimeKind.Utc), page.StartedDateTime);
            Assert.AreEqual("page_2", page.Id);
            Assert.AreEqual("https://www.google.com/", page.Title);
            Assert.AreEqual(2423.999786376953, page.PageTimings.OnContentLoad);
            Assert.AreEqual(2423.999786376953, page.PageTimings.OnLoad);

            page = pages[1];
            Assert.IsNull(page.PageTimings.OnContentLoad);
            Assert.IsNull(page.PageTimings.OnLoad);
        }

        [Test]
        public void Deserialize_HarContent_Entries()
        {
            var entries = m_actual.Log.Entries;
            Assert.AreEqual(60, entries.Count);

            var entry = entries[0];
            Assert.AreEqual(new DateTime(2014, 9, 24, 18, 39, 52, 160, DateTimeKind.Utc), entry.StartedDateTime);
            Assert.AreEqual(946.9997882843018, entry.Time);
            Assert.AreEqual("134139", entry.Connection);
            Assert.AreEqual("page_2", entry.PageRef);
            Assert.IsNull(entry.ServerIPAddress);
            Assert.AreEqual(0, entry.Timings.Blocked);
            Assert.AreEqual(0, entry.Timings.Dns);
            Assert.AreEqual(720.0000000011642, entry.Timings.Connect);
            Assert.AreEqual(0, entry.Timings.Send);
            Assert.AreEqual(225.99999999874854, entry.Timings.Wait);
            Assert.AreEqual(0.9997882843890693, entry.Timings.Receive);
            Assert.AreEqual(548.0000000025029, entry.Timings.Ssl);
        }

        [Test]
        public void Deserialize_HarContent_Timings()
        {
            var timings = m_actual.Log.Entries[0].Timings;

            Assert.AreEqual(0, timings.Blocked);
            Assert.AreEqual(0, timings.Dns);
            Assert.AreEqual(720.0000000011642, timings.Connect);
            Assert.AreEqual(0, timings.Send);
            Assert.AreEqual(225.99999999874854, timings.Wait);
            Assert.AreEqual(0.9997882843890693, timings.Receive);
            Assert.AreEqual(548.0000000025029, timings.Ssl);

            timings = m_actual.Log.Entries[1].Timings;
            Assert.IsNull(timings.Blocked);
            Assert.IsNull(timings.Dns);
            Assert.IsNull(timings.Connect);
            Assert.IsNull(timings.Ssl);
        }

        [Test]
        public void Deserialize_HarContent_Cache()
        {
            var cache = m_actual.Log.Entries[0].Cache;

            Assert.AreEqual(new DateTime(2014, 9, 25, 18, 39, 53), cache.BeforeRequest.Expires);
            Assert.AreEqual(new DateTime(2014, 9, 24, 17, 39, 53), cache.BeforeRequest.LastAccess);
            Assert.AreEqual("test1", cache.BeforeRequest.ETag);
            Assert.AreEqual(1, cache.BeforeRequest.HitCount);
            Assert.IsNotNull(cache.BeforeRequest);

            Assert.IsNotNull(cache.AfterRequest);
            Assert.AreEqual(new DateTime(2014, 9, 26, 19, 39, 53), cache.AfterRequest.Expires);
            Assert.AreEqual(new DateTime(2014, 9, 25, 18, 39, 53), cache.AfterRequest.LastAccess);
            Assert.AreEqual("test2", cache.AfterRequest.ETag);
            Assert.AreEqual(2, cache.AfterRequest.HitCount);
        }

        [Test]
        public void Deserialize_HarContent_Request()
        {
            var request = m_actual.Log.Entries[0].Request;
            Assert.AreEqual("GET", request.Method);
            Assert.AreEqual("https://www.google.com/", request.Url.ToString());
            Assert.AreEqual("HTTP/1.1", request.HttpVersion);
            Assert.AreEqual(0, request.BodySize);
            Assert.AreEqual(1542, request.HeadersSize);
        }

        [Test]
        public void Deserialize_HarContent_Cookies()
        {
            var cookies = m_actual.Log.Entries[0].Request.Cookies;
            Assert.AreEqual(9, cookies.Count);

            var cookie = cookies[0];
            Assert.AreEqual("PREF", cookie.Name);
            Assert.AreEqual("ID=ac8f0e1628ac8f71:U=c1b66ec369dcc09f:FF=0:LD=pt-BR:TM=1409229977:LM=1409230059:GM=1:S=GfV8WG1HURi4SYOq", cookie.Value);
            Assert.IsFalse(cookie.Expires.HasValue);
            Assert.IsFalse(cookie.HttpOnly);
            Assert.IsFalse(cookie.Secure);

            cookie = cookies[1];
            Assert.IsFalse(cookie.HttpOnly);
            Assert.IsFalse(cookie.Secure);
        }

        [Test]
        public void Deserialize_HarContent_Headers()
        {
            var headers = m_actual.Log.Entries[0].Request.Headers;
            Assert.AreEqual(8, headers.Count);

            var header = headers[0];
            Assert.AreEqual("Accept-Encoding", header.Name);
            Assert.AreEqual("gzip,deflate,sdch", header.Value);
        }

        [Test]
        public void Deserialize_HarContent_PostData()
        {
            var postData = m_actual.Log.Entries[0].Request.PostData;
            Assert.IsNull(postData);

            postData = m_actual.Log.Entries[25].Request.PostData;
            Assert.IsNotNull(postData);
            Assert.AreEqual("text/ping", postData.MimeType);
            Assert.AreEqual("PING", postData.Text);
            Assert.AreEqual("PING", postData.Text);
            Assert.AreEqual(1, postData.Params.Count);
            Assert.AreEqual("test.txt", postData.Params[0].FileName);
            Assert.AreEqual("plain/text", postData.Params[0].ContentType);
        }

        [Test]
        public void Deserialize_HarContent_QueryString()
        {
            var queryString = m_actual.Log.Entries[1].Request.QueryString;
            Assert.AreEqual(2, queryString.Count);

            var parameter = queryString[0];
            Assert.AreEqual("gfe_rd", parameter.Name);
            Assert.AreEqual("cr", parameter.Value);
        }

        [Test]
        public void Deserialize_HarContent_Response()
        {
            var response = m_actual.Log.Entries[0].Response;
            Assert.AreEqual(302, response.Status);
            Assert.AreEqual("Found", response.StatusText);
            Assert.AreEqual("HTTP/1.1", response.HttpVersion);
            Assert.AreEqual("https://www.google.com/unit/test", response.RedirectUrl.ToString());
            Assert.AreEqual(273, response.HeadersSize);
            Assert.AreEqual(0, response.BodySize);

            response = m_actual.Log.Entries[1].Response;
            Assert.AreEqual("https://www.google.com.br/?gfe_rd=cr&ei=-Q8jVNr2BteqhQTf0oH4Bw", response.RedirectUrl.ToString());
        }

        [Test]
        public void Deserialize_HarContent_Content()
        {
            var content = m_actual.Log.Entries[0].Response.Content;
            Assert.AreEqual(100, content.Size);
            Assert.AreEqual("text/html", content.MimeType);
            Assert.AreEqual(10, content.Compression);
            Assert.AreEqual("UTF-8", content.Encoding);
            Assert.AreEqual("test content", content.Text);

            content = m_actual.Log.Entries[1].Response.Content;
            Assert.IsNull(content.Compression);
        }        
    }
}

