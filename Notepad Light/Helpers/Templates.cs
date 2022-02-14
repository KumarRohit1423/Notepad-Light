﻿using System.Text;

namespace Notepad_Light.Helpers
{
    public static class Templates
    {
        static StringBuilder sbTemplate1 = new StringBuilder();
        static StringBuilder sbTemplate2 = new StringBuilder();
        static StringBuilder sbTemplate3 = new StringBuilder();
        static StringBuilder sbTemplate4 = new StringBuilder();
        static StringBuilder sbTemplate5 = new StringBuilder();

        public static StringBuilder GetTemplate1()
        {
            return sbTemplate1;
        }

        public static StringBuilder GetTemplate2()
        {
            return sbTemplate2;
        }

        public static StringBuilder GetTemplate3()
        {
            return sbTemplate3;
        }

        public static StringBuilder GetTemplate4()
        {
            return sbTemplate4;
        }

        public static StringBuilder GetTemplate5()
        {
            return sbTemplate5;
        }

        public static void SetTemplate1(string input)
        {
            sbTemplate1.Append(input);
        }

        public static void SetTemplate2(string input)
        {
            sbTemplate2.Append(input);
        }

        public static void SetTemplate3(string input)
        {
            sbTemplate3.Append(input);
        }

        public static void SetTemplate4(string input)
        {
            sbTemplate4.Append(input);
        }

        public static void SetTemplate5(string input)
        {
            sbTemplate5.Append(input);
        }

        public static void WriteTemplatesToFile()
        {
            File.WriteAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template1 + ".txt", sbTemplate1.ToString());
            File.WriteAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template2 + ".txt", sbTemplate2.ToString());
            File.WriteAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template3 + ".txt", sbTemplate3.ToString());
            File.WriteAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template4 + ".txt", sbTemplate4.ToString());
            File.WriteAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template5 + ".txt", sbTemplate5.ToString());
        }

        public static void UpdateTemplatesFromFiles()
        {
            sbTemplate1.Append(File.ReadAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template1 + ".txt"));
            sbTemplate2.Append(File.ReadAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template2 + ".txt"));
            sbTemplate3.Append(File.ReadAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template3 + ".txt"));
            sbTemplate4.Append(File.ReadAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template4 + ".txt"));
            sbTemplate5.Append(File.ReadAllText(Strings.appFolderDirectory + Strings.pathDivider + Properties.Settings.Default.Template5 + ".txt"));
        }        
    }
}