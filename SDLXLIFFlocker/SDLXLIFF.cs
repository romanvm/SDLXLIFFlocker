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

        public int[] Lock100Matches(bool include100PerCent)
        {
            int lockedCount = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {                
                if (sdlseg.GetAttribute("percent") == "100" && sdlseg.GetAttribute("origin") == "tm" && (sdlseg.GetAttribute("text-match") == "SourceAndTarget" || include100PerCent) && sdlseg.GetAttribute("locked") != "true")
                {
                    lockedCount++;
                    sdlseg.SetAttribute("locked", "true");
                }
            }
            return new int[] { lockedCount, sdlsegTags.Count };
        }

        public void ChangeSegmentStatus(string status, bool ignoreLocked)
        {            
            foreach(XmlElement sdlseg in sdlsegTags)
            {
                if (!(sdlseg.GetAttribute("locked") == "true" && ignoreLocked))
                {
                    if (status != "Untranslated")
                    {

                        sdlseg.SetAttribute("conf", status);
                    }
                    else
                    {
                        sdlseg.RemoveAttribute("conf");
                    }
                }                
            }
        }

        public int[] Unlock()
        {
            int unlockedCount = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {
                if (sdlseg.GetAttribute("locked") == "true")
                {
                    unlockedCount++;
                    sdlseg.RemoveAttribute("locked");
                }                
            }
            return new int[] { unlockedCount, sdlsegTags.Count };
        }        

        public List<int> CheckUntranslated(bool ignoreLocked)
        {
            var untransList = new List<int>();
            int segment = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {
                segment++;
                string confAttribute = sdlseg.GetAttribute("conf");
                if ((confAttribute == "" || confAttribute == "Draft") && !(sdlseg.GetAttribute("locked") == "true" && ignoreLocked))
                {
                    untransList.Add(segment);
                }
            }
            return untransList;
        }

        public List<int> CheckUnreviewed(bool ignoreLocked)
        {
            var unrevList = new List<int>();
            int segment = 0;
            foreach (XmlElement sdlseg in sdlsegTags)
            {
                segment++;
                if (sdlseg.GetAttribute("conf") != "ApprovedTranslation" && !(sdlseg.GetAttribute("locked") == "true" && ignoreLocked))
                {
                    unrevList.Add(segment);
                }
            }
            return unrevList;
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
    }
}
