//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RibbonFileManager.Adapters
{
    
    public class MessageReceivedEventArgsAddInAdapter
    {
        internal static RibbonFileManager.Views.MessageReceivedEventArgs ContractToViewAdapter(Start9.Api.Contracts.IMessageReceivedEventArgsContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(MessageReceivedEventArgsViewToContractAddInAdapter))))
            {
                return ((MessageReceivedEventArgsViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new MessageReceivedEventArgsContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IMessageReceivedEventArgsContract ViewToContractAdapter(RibbonFileManager.Views.MessageReceivedEventArgs view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(MessageReceivedEventArgsContractToViewAddInAdapter)))
            {
                return ((MessageReceivedEventArgsContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new MessageReceivedEventArgsViewToContractAddInAdapter(view);
            }
        }
    }
}

