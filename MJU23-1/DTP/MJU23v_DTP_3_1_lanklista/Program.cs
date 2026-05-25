using System;
using System.Diagnostics;

namespace MJU23v_DTP_3_1_lanklista
{
    internal class Program
    {
        static List<WebLink> links;
        class WebLink
        {
            string topic, site, title, link;
            public string Topic { get { return topic; } }
            public string Site { get { return site; } }
            public string Link { get { return link; } }
            public WebLink(string topic, string site, string title, string link)
            {
                this.topic = topic; this.site = site; this.title = title; this.link = link;
            }
            public void Print()
            {
                Console.WriteLine($"Topic: {topic}");
                Console.WriteLine($"  site: {site}");
                Console.WriteLine($"  title: {title}");
                Console.WriteLine($"  link: {link}");
            }
        }
        static void Main(string[] args)
        {
            string[] cmdWithArgs;
            string command;
            do
            {
                Console.Write(": ");
                cmdWithArgs = Console.ReadLine().Split(' ');
                command = cmdWithArgs[0];
                if (command == "load")
                {
                    links = new List<WebLink>(); // Radera länklistan!
                    LoadFile(cmdWithArgs);
                }
                else if (command == "list")
                {
                    ListLinks(cmdWithArgs);
                }
                else if (command == "open")
                {
                    OpenLink(cmdWithArgs);
                }
                else if (command == "quit")
                {
                    Console.WriteLine("Bye!");
                }
                else
                {
                    Console.WriteLine($"Unknown command '{command}'");
                }
            } while (command != "quit");
        }

        private static void LoadFile(string[] cmdWithArgs)
        {
            string fileName = "weblinks.lis";
            if (cmdWithArgs.Length > 1) fileName = cmdWithArgs[1];
            // Filinläsning:
            // FIXME: if fileName doesn't exist, fix exception!
            using (StreamReader SR = new StreamReader(fileName))
            {
                string line = SR.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split(';');
                    WebLink weblink = new WebLink(field[0], field[1], field[2], field[3]);
                    // weblink.Print();
                    links.Add(weblink);

                    line = SR.ReadLine();
                }
            }
            Console.WriteLine($"File {fileName} loaded!");
        }

        private static void ListLinks(string[] cmdWithArgs)
        {
            // TODO: cleanup this, don't know how:
            if (cmdWithArgs.Length > 1)
            {
                string arg1 = cmdWithArgs[1];
                if (arg1 == "topic")
                {
                    if (cmdWithArgs.Length > 2)
                    {
                        string topic = cmdWithArgs[2];
                        ListLinksWithTopic(topic);
                    }
                    else
                        Console.WriteLine("No topic given! Usage: list topic /topic/");
                }
                if (arg1 == "site")
                {
                    if (cmdWithArgs.Length > 2)
                    {
                        string site = cmdWithArgs[2];
                        ListLinksWithSite(site);
                    }
                    else
                        Console.WriteLine("No site given! Usage: list site /site/");
                }
            }
            else
            {
                // FIXME: if links == null error occurs
                int i = 0;
                foreach (WebLink wl in links) // FIXME: forloop
                {
                    Console.Write(i++ + ": ");
                    wl.Print();  // FIXME: if wl == null error occurs:
                }
            }
        }

        private static void ListLinksWithTopic(string topic)
        {
            for (int i = 0; i < links.Count; i++)
            {
                if (links[i].Topic == topic)
                {
                    Console.Write(i + ": ");
                    links[i].Print();
                }
            }
        }
        private static void ListLinksWithSite(string site)
        {
            for (int i = 0; i < links.Count; i++)
            {
                if (links[i].Site == site)
                {
                    Console.Write(i + ": ");
                    links[i].Print();
                }
            }
        }

        private static void OpenLink(string[] cmdWithArgs)
        {
            if (cmdWithArgs.Length > 1)
            {
                if (cmdWithArgs[1] == "topic")
                {
                    if (cmdWithArgs.Length > 2)
                    {
                        foreach(WebLink wl in links)
                        {
                            if (wl.Topic == cmdWithArgs[2])
                            {
                                Process application = new Process();
                                application.StartInfo.UseShellExecute = true;
                                application.StartInfo.FileName = wl.Link;
                                application.Start();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No topic given! Usage: open topic /topic/");
                    }
                }
                else
                {
                    int index = Int32.Parse(cmdWithArgs[1]); // FIXME: crash if not number!!
                    StartLink(index);
                }
            }
            else
            {
                Console.WriteLine("No index given! Usage: open /index/");
            }
        }

        private static void StartLink(int index)
        {
            Process application = new Process();
            application.StartInfo.UseShellExecute = true;
            application.StartInfo.FileName = links[index].Link;
            application.Start();
        }
    }
}