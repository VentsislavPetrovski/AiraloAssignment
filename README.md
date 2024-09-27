# AiraloAssignment
The project is written in C#. It utilizes ReshSharp as the API Client and Playwright for the FE tests.

# Running the tests
## Prerequisites
- .NET8 installed
- IDE installed (preferably Visual Studio)

## Setting up the tests
- Clone the repository
- Open the AiraloAssignment.sln with the IDE
- Build the solution
- Select the runsettings for the PlaywrightConfig from Test -> Configure Run Settings -> Select Solution Wide file -> Select the runsettings file from AiraloAssignment\UISetup\playwrightConfig.runsettings

## Installing the browsers for Playwright
Playwright for .NET requires the user to install the browsers required for testing. This is easily done with a powershell script. Make sure the solution is aleady built before navigating to the script!
### Installation steps
- Locate the powershell script in the project directory AiraloAssignment\bin\Debug\net8.0\playwright.ps1
- Right click on the script and select "Copy as path" option
- Open a powershell and type "powershell {scriptPathIsPastedHere} install"
- Wait for the browsers to finish downloading and installing

## Execution of tests
The tests are now ready to be run. This can be achieved in multiple ways via cmdline or VS GUI.
- Open the solution in VS
- Build the solution if needed
- Select Test -> Test Explorer
- The Test Explorer window should be opened.
- Right click on any test and select "Run"

# Overview of test cases
## API
For the API test a simple setup was created using DI Container, Authorization handler and appsetings file. The environment configuration is saved in the appsettings.json file and is extracted and saved as singleton in the Container. The container is started in the OneTimeSetupMethod in the SetupFixture class. Each endpoint is described as method and there are 3 classes for each API Controller based on the Airalo API Documentation. Authorization is handled automatically, and the GET Token request is only saved once and reused for subsequent api calls. This is handled in the AuthorizationHelper class. Separate DTOs are created for each endpoint's request and response.

### NOTE!!!
The task stated ![image](https://github.com/user-attachments/assets/cc848c65-ba3a-4541-979a-d153e12ca810) however when I used the required endpoint no sim card data is returned so I could not verify 6 cards are present with this packageID.
- Airalo documentation mock response: ![image](https://github.com/user-attachments/assets/851461a6-cc1f-4905-83fb-47e23e80a7af)
- Real response ![image](https://github.com/user-attachments/assets/ebf46c34-1b4c-4759-a3a7-159f6f48f049)
As we can see the simable object is missing.

## UI 
The UI test is straightforward. Due to using playwright the setup is very easy, and there are no need for explicit waits, because they are handled automatically. PageObject model is leveraged however due to the simplicity of the task its not needed. The tests are run in chromium with headful mode and with 1920x1080 resolution.
