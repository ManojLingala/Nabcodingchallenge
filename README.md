# NabCodingChallenge

# Prerequistie : 

To run source code on your local machine you need

- git to clone source (of course) or use Download To Desktop
- Visual Studio 2017 (Community is Ok)
- Net Core 2.0 SDK
- NET Core 2.0 CLI

I have used Visual Studio for Mac Community Edition - .NET core for the development to make it cross platform. 

Please refer to my article for setting up the FullStackDotNet Development on Mac. [FullStackDotNetDevelopmentOnMac](https://gist.github.com/ManojLingala/d54cadcd5b4a2b495866e5ace99a09d7?raw=true)

# Requirement :

As per the requirement I have outputted a list of only cat's in alphabetical order under two headings (male, female) based on the owner’s gender.

![Alt text](https://raw.githubusercontent.com/ManojLingala/Ansible-Playbook/master/Images/Outputfile.PNG?raw=true "Output File")

![Alt text](https://raw.githubusercontent.com/ManojLingala/Ansible-Playbook/master/Images/PetsAPi.PNG?raw=true "Pets Json")

Note : `Dog's and Fish are not considered`.

# Build:

The solution can be build and run directly from Visual Studio 2017 with support .net core 2.0.

If you don't have visual studio 2017 install on machine, Solution can be built with .NET core CLI.

`dotnet restore && dot build`

Read my above mentioned article for further assisstance

# Test:

The Test project is implemented with XUnit can be execute from source with Net Core CLI.

`dotnet test NabCodingChallenge.Test/NabCodingChallenge.Test.csproj`

Test can also run wit compiled Test assembly

`dotnet test NabCodingChallenge.Test/bin/Debug/netcoreapp2.0/NabCodingChallenge.Test.dll`

# CI & Deployment: 

This project is pre-configure with (https://travis-ci.org "Travis CI"). 
When the build finish, Travis will deploy to azure website. Make sure you setup Azure Username, Password, and Sitename inside Travis Setting. 

Travis CI is been used for CI/CD and the ![Build Status](https://travis-ci.org/ManojLingala/Nabcodingchallenge.svg?branch=master)
 (https://travis-ci.org/ManojLingala/Nabcodingchallenge)




