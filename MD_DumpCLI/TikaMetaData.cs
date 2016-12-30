using System;
using System.Collections.Generic;
using System.Linq;
using TikaOnDotNet.TextExtraction;

namespace MD_DumpCLI
{
    public class TikaMetaData
    {
        public static string TikaText = string.Empty;

        public static void TikaExtractAll(string _filename, bool bGiveContent = false)
        {
            var results = new Dictionary<string, string>();

            try
            {
                var textExtractor = new TextExtractor();
                var result = textExtractor.Extract(_filename);

                foreach (var dict in result.Metadata.OrderBy(x => x.Key))
                {
                        try
                        {
                            Console.Write("\n{0}: ", dict.Key.ToString());
                            Console.Write("{0}", dict.Value ?? string.Empty);
                            //Console.WriteLine("\n------");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception", ex.Message);
                        }
                }

                if(bGiveContent)   
                   Console.Write(result.Text.Trim());

                result = null;
                textExtractor = null;
            }

            catch (TikaOnDotNet.TextExtraction.TextExtractionException tex)
            {
                Console.WriteLine("Tika Exception", tex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception", ex.Message);
            }

            
        }
    }
}
