# SignalR using ASP.NET Core and .Net 7

This is a simple application on how to use SignalR using ASP.NET Core and .Net 7

## Installation

There's no required prerequisite to get the project running. Just ensure to build the project to automatically install [Microsoft.AspNetCore.SignalR.Client](https://www.nuget.org/packages/Microsoft.AspNetCore.SignalR.Client/7.0.8/)

## Testing it with Postman

Run the project. Open a postman then click File > New and select WebSocket Request. Instead of using http or https, we will be using wss and with that we will get this as url wss://localhost:7105/chat-hub.

Hit Connect to establish connection.

Add the following to New Message

> {"protocol":"json","version":1}

Click Send and you will received a response like this.

>> {"type":1,"target":"ReceivedMessage","arguments":["ZxbYAsDDnrwgKtyZLJ-tEA has joined."]}

Client may also sent a message to all clients by using the following in the New Message

> {"arguments":["Hello there"],"invocationId": "0", "target":"SendMessage","type":1}

It will respond like this.

>> {"type":1,"target":"ReceivedMessage","arguments":["zM_LYcw6aJhRS4FhROfbTg: Hello there."]}

If you take a look into Program.cs, there's a `broadcast` post method there to send notifications to all clients. You can either test it using Postman or with swagger definition after running the app.

## Contributing

Pull requests are not welcome. The intention of this is to provide a brief example on how to use the package for SignalR development.

## Resources

https://www.rafaagahbichelab.dev/articles/signalr-dotnet-postman
[Milan Jovanović Youtube Channel](https://www.youtube.com/watch?v=9_pRk7PwkpY&ab_channel=MilanJovanovi%C4%87)

## License

NA