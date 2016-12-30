# MD_DumpCLI
A program to view file metadata and file content using Apache Tika in .NET.

This program will allow you to use the power of Apache Tika 1.6 in the .NET framework. The primary benefits of this are not needing Java and speed. It uses a .NET implementation of the Java framework called IKVM.

To retrieve metadata from a file it's easy.

**To retrieve only metadata:**
MD_DumpCLI.exe -f "N:\Test_data\eml\test_sample_message.eml"

**To retrieve metadata and content.**
MD_DumpCLI.exe -f "N:\Test_data\eml\test_sample_message.eml" -c True

**Example commandline output:**
  E:\MD_DumpCLI>MD_DumpCLI.exe -f "N:\Test_data\eml\test_sample_message.eml" -c True
  Author:  David Dym
  License: Apache 2.0
   https://www.apache.org/licenses/

  Filename: N:\Test_data\eml\test_sample_message.eml

  ....metdata

**Compiling**
Compiling is simple. You will need Visual Studio 2015 Community (free) or better and the .Net 4.6 framework. The solution should auto download the following nuget packages below and compile the project.

**Dependencies**
    Apache Tika: https://tika.apache.org/
    IKVM: http://www.ikvm.net/
    TikaOnDotNET: https://kevm.github.io/tikaondotnet/


Enjoy!
