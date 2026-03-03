
# Open editor to add project assets
dotnet mgcb-editor

# Building and Running
dotnet build
dotnet run -v diag
dotnet run > output.txt 2>&1  //will output to a text file

# Adding a Reference To The Class Library
dotnet add reference ../MonoGameLibrary/MonoGameLibrary.csproj