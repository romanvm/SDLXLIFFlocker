using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace SDLXLIFFlocker
{
    class SDLXLIFF
    {
        XmlDocument sdlxliff;
        XmlNodeList sdlsegTags;
        string filePath;

        public SDLXLIFF(string path)
        {
            sdlxliff = new XmlDocument();
            filePath = path;            
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                sdlxliff.LoadXml(reader.ReadToEnd());
            }            
            sdlsegTags = sdlxliff.GetElementsByTagName("sdl:seg");
        }

        public int[] Lock100Matches()
        {
            int lockedCount = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {                
                if (sdlseg.GetAttribute("percent") == "100" && sdlseg.GetAttribute("origin") == "tm"  && sdlseg.GetAttribute("locked") != "true")
                {
                    lockedCount++;
                    sdlseg.SetAttribute("locked", "true");
                }
            }
            return new int[2] { lockedCount, sdlsegTags.Count };
        }

        public void Unlock()
        {
            foreach (XmlElement sdlseg in sdlsegTags)
            {
                if (sdlseg.GetAttribute("locked") == "true")
                {
                    sdlseg.RemoveAttribute("locked");
                }                
            }
        }

        public void Write()
        {
            using (FileStream fileStream = File.Create(filePath))
            {
                var writer = new XmlTextWriter(fileStream, Encoding.UTF8);
                sdlxliff.WriteContentTo(writer);
                writer.Flush();
            }
        }

        public List<int> CheckUntranslated(bool ignoreLocked = false)
        {
            var untransList = new List<int>();
            int segment = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {
                segment++;
                if (sdlseg.GetAttribute("conf") == "" && !(sdlseg.GetAttribute("locked") == "true" && ignoreLocked))
                {
                    untransList.Add(segment);
                }
            }
            return untransList;
        }
    }
}
