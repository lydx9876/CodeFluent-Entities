﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.SignalR.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 03 November 2014 12:12.
    // Build:1.0.61214.0786
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.softfluent.com/samples/signalr")]
    public partial interface ICustomerService
    {
        
        [System.ServiceModel.OperationContractAttribute()]
        string Validate(SoftFluent.Samples.SignalR.Customer customer, string culture);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Delete(SoftFluent.Samples.SignalR.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute()]
        SoftFluent.Samples.SignalR.Customer Load(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        SoftFluent.Samples.SignalR.Customer LoadById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Save(SoftFluent.Samples.SignalR.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool SaveByRef(ref SoftFluent.Samples.SignalR.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute()]
        SoftFluent.Samples.SignalR.Customer LoadByEntityKey(string key);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool DeleteByKey(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        void SaveAll(SoftFluent.Samples.SignalR.CustomerCollection customerCollection);
        
        [System.ServiceModel.OperationContractAttribute()]
        SoftFluent.Samples.SignalR.CustomerCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions);
        
        [System.ServiceModel.OperationContractAttribute()]
        SoftFluent.Samples.SignalR.CustomerCollection LoadAll();
    }
}