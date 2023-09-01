# WASDI C# Tutorial application

## General 
This repository contains a Visual Studio Solution that, relying on the dedicate WASDI library, showcase the integration of WASDI with custom developed application using the C# language.

The library encapsulate all the operations available in WASDI, allowing to extend the features with custom libraries and further functionalities.

for an overview of the available functionalities and the details of the library you can refer to the [Wasdi documentation center](https://wasdi.readthedocs.io) and, in particular, to [C# reference page](https://wasdi.readthedocs.io/en/latest/Libraries/c%23/WasdiLib.html)

 
## Requirements 
To execute, test and experiment these are the reccomended requirements
- Visual studio 2022 
- An active WASDI account

In case an account is not available you can [register here](https://www.example.com)

## Getting started 

The JSON file `appsettings.json` contains the credentials to connect to WASDI services
```json
{
    "USER": "your_username",
    "PASSWORD": "your_password",
    "BASEPATH=": "C:/temp/wasdi/",
    "BASEURL": "https://www.wasdi.net/wasdiwebserver/rest",
    "WORKSPACE": "TutorialWorkspace",
    "PARAMETERSFILEPATH": "./parameters.json"
}
```

Please, as a first step change the parameters `USER` and `PASSWORD` to connect successfully to the WASDI server.

`WORKSPACE` must be an existing workspace from your WASDI account. If you still don't have one use the WASDI application to create one. You can then reference to it from this application.

The code showcase the SearchEOImages function and the excecution of a WASDI application from WASDI called "HelloWasdiWorld". 

I'm pretty sure you can guess the scope of the latest :-) 

If you have doubts/questions please contact us on our [discord support channel](https://discord.com/channels/937730046335017002/937732461897609307)