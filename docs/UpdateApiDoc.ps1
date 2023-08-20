# uses the XMLDoc2Markdown dotnet-tool from https://github.com/charlesdevandiere/xmldoc2md
# install with: 
# dotnet tool install -g XMLDoc2Markdown

# this regenerates the Api-documentation in the "ApiDoc"-folder
# the file "ApiDoc/index.md" was moved into the "docs" folder to work nicely with github-pages
# (links in index.md had to be adapted after moving)

xmldoc2md ..\src\foundation\src\PDFsharp\tests\PdfSharp.Tests\bin\Debug\net6.0\PdfSharp.dll ApiDoc\ --github-pages
