[Export(typeof(HomagGroup.FLS.Infrastructure.Common.Customization.IUserExit))]
[Export("Plumeyer", typeof(HomagGroup.FLS.Services.Common.Service.Messaging.IScannerUserExit))]
public class Plumeyer : HomagGroup.FLS.Infrastructure.Common.Customization.UserExitBase, HomagGroup.FLS.Services.Common.Service.Messaging.IScannerUserExit
{
    
    public void Execute(string receivedMessage, string parameter, HomagGroup.FLS.Services.Common.Service.Messaging.Provider.CustomScannerMessageHandler handler)
    {
       
    }
}
