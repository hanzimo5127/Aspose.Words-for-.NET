﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words.Fonts;

namespace Aspose.Words.Examples.CSharp.Rendering_Printing
{
    class SetFontsFolders
    {
        public static void Run()
        {
            // ExStart:SetFontsFolders
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_RenderingAndPrinting();

            FontSettings.DefaultInstance.SetFontsSources(new FontSourceBase[]
            {
                new SystemFontSource(), new FolderFontSource("C:\\MyFonts\\", true)
            });

            Document doc = new Document(dataDir + "Rendering.doc");
            dataDir = dataDir + "Rendering.SetFontsFolders_out.pdf";
            doc.Save(dataDir);
            // ExEnd:SetFontsFolders           
        }
    }
}
