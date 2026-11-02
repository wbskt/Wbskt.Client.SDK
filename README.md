> [!WARNING]
> **This repository is archived and no longer maintained.** It is the original client, from before
> the device protocol was written down, and it does not speak that protocol.
>
> The .NET SDK now lives in [wbskt/Wbskt](https://github.com/wbskt/Wbskt) under
> `Clients/Wbskt.Client.Sdk`, and ships under the same package name, `Wbskt.Client`, from
> `1.0.0-preview.1`. The `0.x` versions on nuget.org are this code and are deprecated: move to the
> new package. For other platforms, see the ESP32 library
> ([wbskt/Wbskt.Arduino](https://github.com/wbskt/Wbskt.Arduino)) and the Python SDK
> (`Clients/python` in wbskt/Wbskt). The protocol itself is `Docs/Device.Protocol.md` there.

### Wbskt Client for Real-Time Communication

Wbskt.Client.CSharp project is a .NET-based client library designed for seamless real-time communication with the Wbskt platform. It provides robust features for managing WebSocket connections, sending and receiving messages, and handling authentication via JWT tokens. The library is highly configurable, supporting dynamic settings through `IOptionsMonitor` or custom configurations. Key functionalities include:

- **WebSocket Communication**: Establishes and maintains WebSocket connections with retry mechanisms.
- **Authentication**: Secure token-based authentication using JWT.
- **Message Handling**: Processes incoming and outgoing messages with extensible payload handling.
- **Configuration Support**: Flexible configuration options for server address, client details, and channel subscriptions.
- **Logging**: Integrated logging for debugging and monitoring.

---

This project is ideal for applications requiring real-time updates, such as chat systems, live notifications, collaborative tools, and IoT services.

---

#### Setup

Go to [wbskt.com](https://wbskt.com), log in, and create a registration policy. You will need to provide a `Pin`.

##### Now in your .NET application:

Add a reference to the `Wbskt.Client.CSharp` library from [nuget.org](https://nuget.org), and then in your code:

```csharp
var config = new WbsktConfigurationCustom
{
    PolicyDetails = new PolicyDetails()
    {
        Pin = 1234 // The PIN for the registration policy.
    },
    ClientDetails = new ClientDetails
    {
        Name = "Bob's Application",
        UniqueId = Guid.NewGuid()
    },
};
```

Once you have the configuration, you can start listening:

````csharp
// Your custom method. This will be triggered when an event is fired on the Wbskt server.
void BobsFunction(ClientPayload payload)
{
    // Your custom logic here.
}

// Initialize a listener (you can even have multiple listeners listening to different channels).
var listener = new WbsktListener(config);

// Register your method to the event.
listener.ReceivedPayloadEvent += BobsFunction;

// You can also have multiple custom methods registered to the same event.
listener.ReceivedPayloadEvent += AlicesFunction;

// Start listening.
listener.StartListening();

// Stop listening.
listener.StopListening();
````