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
    
    public class IConfigurationContractToViewAddInAdapter : RibbonFileManager.Views.IConfiguration
    {
        private Start9.Api.Contracts.IConfigurationContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IConfigurationContractToViewAddInAdapter()
        {
        }
        public IConfigurationContractToViewAddInAdapter(Start9.Api.Contracts.IConfigurationContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public System.Collections.Generic.IList<RibbonFileManager.Views.IConfigurationEntry> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IConfigurationEntryContract, RibbonFileManager.Views.IConfigurationEntry>(_contract.Entries, RibbonFileManager.Adapters.IConfigurationEntryAddInAdapter.ContractToViewAdapter, RibbonFileManager.Adapters.IConfigurationEntryAddInAdapter.ViewToContractAdapter);
            }
        }
        internal Start9.Api.Contracts.IConfigurationContract GetSourceContract()
        {
            return _contract;
        }
    }
}

