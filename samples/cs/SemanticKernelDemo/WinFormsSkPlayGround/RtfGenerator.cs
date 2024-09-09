using System.Text;

namespace SemanticKernelDemo;

public static class RtfGenerator
{
    public static string GenerateRtf()
    {
        StringBuilder rtf = new StringBuilder();

        // RTF header  
        rtf.Append(@"{\rtf1\ansi\deff0");

        // Define font table  
        rtf.Append(@"{\fonttbl{\f0 Arial;}{\f1 Courier New;}{\f2 Times New Roman;}}");

        // Define color table  
        rtf.Append(@"{\colortbl ;\red0\green0\blue0;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;}");

        // Start of document content  
        rtf.Append(@"\viewkind4\uc1\pard\lang1033\f0\fs24");

        // Plain text  
        rtf.Append(@"Lorem Ipsum ");

        // Bold text  
        rtf.Append(@"\b Lorem Ipsum\b0 ");

        // Italic text  
        rtf.Append(@"\i Lorem Ipsum\i0 ");

        // Underlined text  
        rtf.Append(@"\ul Lorem Ipsum\ul0 ");

        // Colored text  
        rtf.Append(@"\cf2 Lorem Ipsum\cf0 "); // Red  
        rtf.Append(@"\cf3 Lorem Ipsum\cf0 "); // Green  
        rtf.Append(@"\cf4 Lorem Ipsum\cf0 "); // Blue  

        // Different font sizes  
        rtf.Append(@"\fs48 Lorem Ipsum\fs24 "); // Larger font  
        rtf.Append(@"\fs12 Lorem Ipsum\fs24 "); // Smaller font  

        // Different fonts  
        rtf.Append(@"\f1 Lorem Ipsum\f0 "); // Courier New  
        rtf.Append(@"\f2 Lorem Ipsum\f0 "); // Times New Roman  

        // End of document content  
        rtf.Append(@"\par}");

        return rtf.ToString();
    }
}
