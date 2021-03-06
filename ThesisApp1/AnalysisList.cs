using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThesisApp1
{
    public class AnalysisList
    {

        public string FileSavedIn { get; set; }
        public string TopDirectory { get; set; }
        
        public List<AnalysisEvent> EventList { get; }

        //parameterless constructor
        public AnalysisList()
        {
            FileSavedIn = String.Empty;
            EventList = new List<AnalysisEvent>();
        }

        public AnalysisList(string topFolder)
        {
            FileSavedIn = String.Empty;
            TopDirectory = topFolder;
            EventList = new List<AnalysisEvent>();
        }

        //This method iterates through the given directory to find all files with the .xml extension.
        //The algorithm was taken from the microsoft docs.
        //URL: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree
        //Upon finding XML files, it processes them under the assumption that they are
        //valid ATLAS event data.
        public void RunAnalysis()
        {
            Stack<string> subDirs = new Stack<string>();
            subDirs.Push(TopDirectory);

            while (subDirs.Count > 0)
            {
                string currentDir = subDirs.Pop();

                string[] subFolders;
                try
                {
                    subFolders = Directory.GetDirectories(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }

                string[] filesHere = null;
                try
                {
                    filesHere = Directory.GetFiles(currentDir, "*.xml");
                }
                catch (UnauthorizedAccessException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }

                string[] zipsHere = null;
                try
                {
                    zipsHere = Directory.GetFiles(currentDir, "*.zip");
                }
                catch (UnauthorizedAccessException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }

                foreach (string folder in subFolders)
                {
                    subDirs.Push(folder);
                }

                foreach (string file in filesHere)
                {
                    AnalysisEvent nextEvent = new AnalysisEvent(file);
                    nextEvent.SearchForParticles();
                    if (nextEvent.HasMuons || nextEvent.HasElectrons)
                    {
                        AddEvent(nextEvent);
                    }
                }

                foreach (string zipFile in zipsHere)
                {
                    using (ZipArchive archive = ZipFile.OpenRead(zipFile))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (entry.FullName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                            {
                                string pathToData = zipFile + entry.FullName;

                                using (Stream fileStream = entry.Open())
                                {
                                    AnalysisEvent nextEvent = new AnalysisEvent(pathToData, fileStream);
                                    nextEvent.SearchForParticles();
                                    if (nextEvent.HasMuons || nextEvent.HasElectrons)
                                    {
                                        AddEvent(nextEvent);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool AddEvent(AnalysisEvent newEvent)
        {
            int insertIndex = EventList.BinarySearch(newEvent, new EventComparer());

            if (insertIndex < 0)
            {
                EventList.Insert(~insertIndex, newEvent);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string outputString = "This analysis contains " + EventList.Count + " events:\n";
            foreach (AnalysisEvent item in EventList)
            {
                outputString += "\n" + item.ToString();
            }

            return outputString;
        }

    }
}
