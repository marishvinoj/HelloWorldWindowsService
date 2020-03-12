# HelloWorldWindowsService
Install/uninstall Console Application using Topshelf command.

Run Command Prompt as an Administrator and navigate to the bin/debug folder of Console Application.
<provide your path> in cmd window and then use the below command

> HelloWorldWindowsService.exe install

To uninstall windows service run this command.

> HelloWorldWindowsService.exe uninstall

1.After installing your services using the above code go to Services.msc, then check one new service is listed in the list with the name of HelloWorldWindowsService

2. After unistall your services using the above code go to Services.msc, then check that new service is will removed automatillcally from the list.
