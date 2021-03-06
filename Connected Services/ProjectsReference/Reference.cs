﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectsReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", ConfigurationName="ProjectsReference.Projects_ARGGOBEST_Port")]
    public interface Projects_ARGGOBEST_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.Read_Result> ReadAsync(ProjectsReference.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.ReadByRecId_Result> ReadByRecIdAsync(ProjectsReference.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.ReadMultiple_Result> ReadMultipleAsync(ProjectsReference.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.IsUpdated_Result> IsUpdatedAsync(ProjectsReference.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(ProjectsReference.GetRecIdFromKey request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.Create_Result> CreateAsync(ProjectsReference.Create request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:CreateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.CreateMultiple_Result> CreateMultipleAsync(ProjectsReference.CreateMultiple request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.Update_Result> UpdateAsync(ProjectsReference.Update request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:UpdateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.UpdateMultiple_Result> UpdateMultipleAsync(ProjectsReference.UpdateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/projects_arggobest:Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ProjectsReference.Delete_Result> DeleteAsync(ProjectsReference.Delete request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest")]
    public partial class Projects_ARGGOBEST
    {
        
        private string keyField;
        
        private int project_IDField;
        
        private bool project_IDFieldSpecified;
        
        private string project_TitleField;
        
        private string project_DescriptionField;
        
        private string customer_IDField;
        
        private int pM_User_IDField;
        
        private bool pM_User_IDFieldSpecified;
        
        private Project_Status project_StatusField;
        
        private bool project_StatusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Project_ID
        {
            get
            {
                return this.project_IDField;
            }
            set
            {
                this.project_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Project_IDSpecified
        {
            get
            {
                return this.project_IDFieldSpecified;
            }
            set
            {
                this.project_IDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Project_Title
        {
            get
            {
                return this.project_TitleField;
            }
            set
            {
                this.project_TitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Project_Description
        {
            get
            {
                return this.project_DescriptionField;
            }
            set
            {
                this.project_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Customer_ID
        {
            get
            {
                return this.customer_IDField;
            }
            set
            {
                this.customer_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int PM_User_ID
        {
            get
            {
                return this.pM_User_IDField;
            }
            set
            {
                this.pM_User_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PM_User_IDSpecified
        {
            get
            {
                return this.pM_User_IDFieldSpecified;
            }
            set
            {
                this.pM_User_IDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Project_Status Project_Status
        {
            get
            {
                return this.project_StatusField;
            }
            set
            {
                this.project_StatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Project_StatusSpecified
        {
            get
            {
                return this.project_StatusFieldSpecified;
            }
            set
            {
                this.project_StatusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest")]
    public enum Project_Status
    {
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        In_Progress,
        
        /// <remarks/>
        Finished,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest")]
    public partial class Projects_ARGGOBEST_Filter
    {
        
        private Projects_ARGGOBEST_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Projects_ARGGOBEST_Fields Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest")]
    public enum Projects_ARGGOBEST_Fields
    {
        
        /// <remarks/>
        Project_ID,
        
        /// <remarks/>
        Project_Title,
        
        /// <remarks/>
        Project_Description,
        
        /// <remarks/>
        Customer_ID,
        
        /// <remarks/>
        PM_User_ID,
        
        /// <remarks/>
        Project_Status,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public int Project_ID;
        
        public Read()
        {
        }
        
        public Read(int Project_ID)
        {
            this.Project_ID = Project_ID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public Read_Result()
        {
        }
        
        public Read_Result(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public string recId;
        
        public ReadByRecId()
        {
        }
        
        public ReadByRecId(string recId)
        {
            this.recId = recId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public ProjectsReference.Projects_ARGGOBEST_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(ProjectsReference.Projects_ARGGOBEST_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProjectsReference.Projects_ARGGOBEST[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(ProjectsReference.Projects_ARGGOBEST[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public string Key;
        
        public IsUpdated()
        {
        }
        
        public IsUpdated(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public bool IsUpdated_Result1;
        
        public IsUpdated_Result()
        {
        }
        
        public IsUpdated_Result(bool IsUpdated_Result1)
        {
            this.IsUpdated_Result1 = IsUpdated_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public string Key;
        
        public GetRecIdFromKey()
        {
        }
        
        public GetRecIdFromKey(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public string GetRecIdFromKey_Result1;
        
        public GetRecIdFromKey_Result()
        {
        }
        
        public GetRecIdFromKey_Result(string GetRecIdFromKey_Result1)
        {
            this.GetRecIdFromKey_Result1 = GetRecIdFromKey_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Create
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public Create()
        {
        }
        
        public Create(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Create_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public Create_Result()
        {
        }
        
        public Create_Result(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class CreateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List;
        
        public CreateMultiple()
        {
        }
        
        public CreateMultiple(ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List)
        {
            this.Projects_ARGGOBEST_List = Projects_ARGGOBEST_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class CreateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List;
        
        public CreateMultiple_Result()
        {
        }
        
        public CreateMultiple_Result(ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List)
        {
            this.Projects_ARGGOBEST_List = Projects_ARGGOBEST_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Update
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public Update()
        {
        }
        
        public Update(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Update_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST;
        
        public Update_Result()
        {
        }
        
        public Update_Result(ProjectsReference.Projects_ARGGOBEST Projects_ARGGOBEST)
        {
            this.Projects_ARGGOBEST = Projects_ARGGOBEST;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class UpdateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List;
        
        public UpdateMultiple()
        {
        }
        
        public UpdateMultiple(ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List)
        {
            this.Projects_ARGGOBEST_List = Projects_ARGGOBEST_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class UpdateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List;
        
        public UpdateMultiple_Result()
        {
        }
        
        public UpdateMultiple_Result(ProjectsReference.Projects_ARGGOBEST[] Projects_ARGGOBEST_List)
        {
            this.Projects_ARGGOBEST_List = Projects_ARGGOBEST_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Delete
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public string Key;
        
        public Delete()
        {
        }
        
        public Delete(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", IsWrapped=true)]
    public partial class Delete_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_Result", Namespace="urn:microsoft-dynamics-schemas/page/projects_arggobest", Order=0)]
        public bool Delete_Result1;
        
        public Delete_Result()
        {
        }
        
        public Delete_Result(bool Delete_Result1)
        {
            this.Delete_Result1 = Delete_Result1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface Projects_ARGGOBEST_PortChannel : ProjectsReference.Projects_ARGGOBEST_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class Projects_ARGGOBEST_PortClient : System.ServiceModel.ClientBase<ProjectsReference.Projects_ARGGOBEST_Port>, ProjectsReference.Projects_ARGGOBEST_Port
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Projects_ARGGOBEST_PortClient() : 
                base(Projects_ARGGOBEST_PortClient.GetDefaultBinding(), Projects_ARGGOBEST_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.Projects_ARGGOBEST_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Projects_ARGGOBEST_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(Projects_ARGGOBEST_PortClient.GetBindingForEndpoint(endpointConfiguration), Projects_ARGGOBEST_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Projects_ARGGOBEST_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Projects_ARGGOBEST_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Projects_ARGGOBEST_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Projects_ARGGOBEST_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Projects_ARGGOBEST_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.Read_Result> ProjectsReference.Projects_ARGGOBEST_Port.ReadAsync(ProjectsReference.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.Read_Result> ReadAsync(int Project_ID)
        {
            ProjectsReference.Read inValue = new ProjectsReference.Read();
            inValue.Project_ID = Project_ID;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.ReadByRecId_Result> ProjectsReference.Projects_ARGGOBEST_Port.ReadByRecIdAsync(ProjectsReference.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.ReadByRecId_Result> ReadByRecIdAsync(string recId)
        {
            ProjectsReference.ReadByRecId inValue = new ProjectsReference.ReadByRecId();
            inValue.recId = recId;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.ReadMultiple_Result> ProjectsReference.Projects_ARGGOBEST_Port.ReadMultipleAsync(ProjectsReference.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.ReadMultiple_Result> ReadMultipleAsync(ProjectsReference.Projects_ARGGOBEST_Filter[] filter, string bookmarkKey, int setSize)
        {
            ProjectsReference.ReadMultiple inValue = new ProjectsReference.ReadMultiple();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.IsUpdated_Result> ProjectsReference.Projects_ARGGOBEST_Port.IsUpdatedAsync(ProjectsReference.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.IsUpdated_Result> IsUpdatedAsync(string Key)
        {
            ProjectsReference.IsUpdated inValue = new ProjectsReference.IsUpdated();
            inValue.Key = Key;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.GetRecIdFromKey_Result> ProjectsReference.Projects_ARGGOBEST_Port.GetRecIdFromKeyAsync(ProjectsReference.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(string Key)
        {
            ProjectsReference.GetRecIdFromKey inValue = new ProjectsReference.GetRecIdFromKey();
            inValue.Key = Key;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.Create_Result> CreateAsync(ProjectsReference.Create request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.CreateMultiple_Result> CreateMultipleAsync(ProjectsReference.CreateMultiple request)
        {
            return base.Channel.CreateMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.Update_Result> UpdateAsync(ProjectsReference.Update request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.UpdateMultiple_Result> UpdateMultipleAsync(ProjectsReference.UpdateMultiple request)
        {
            return base.Channel.UpdateMultipleAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectsReference.Delete_Result> ProjectsReference.Projects_ARGGOBEST_Port.DeleteAsync(ProjectsReference.Delete request)
        {
            return base.Channel.DeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectsReference.Delete_Result> DeleteAsync(string Key)
        {
            ProjectsReference.Delete inValue = new ProjectsReference.Delete();
            inValue.Key = Key;
            return ((ProjectsReference.Projects_ARGGOBEST_Port)(this)).DeleteAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Projects_ARGGOBEST_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Projects_ARGGOBEST_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://nav2018.arggo.consulting:7052/ARGGOBEST/WS/Cronus03/Page/Projects_ARGGOBES" +
                        "T?wsdl");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Projects_ARGGOBEST_PortClient.GetBindingForEndpoint(EndpointConfiguration.Projects_ARGGOBEST_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Projects_ARGGOBEST_PortClient.GetEndpointAddress(EndpointConfiguration.Projects_ARGGOBEST_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            Projects_ARGGOBEST_Port,
        }
    }
}
