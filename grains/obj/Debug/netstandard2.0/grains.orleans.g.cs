// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof (OrleansGeneratedCode.OrleansCodeGenbb451b9d89FeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"grains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleansGeneratedCode7D0B6812
{
    using global::Orleans;
    using global::System.Reflection;
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGenbb451b9d89FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof (global::grains.ConversationGrain)));
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof (global::grains.SimpleTextGrain)));
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof (global::Name.AgentGrain)));
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddKnownType(@"grains.ConversationGrain,grains", @"grains.ConversationGrain");
            feature.AddKnownType(@"grains.SimpleTextGrain,grains", @"grains.SimpleTextGrain");
            feature.AddKnownType(@"Name.AgentGrain,grains", @"Name.AgentGrain");
            feature.AddKnownType(@"System.Runtime.Serialization.Formatters.FormatterAssemblyStyle,Newtonsoft.Json", @"FormatterAssemblyStyle");
            feature.AddKnownType(@"Newtonsoft.Json.SerializationBinder,Newtonsoft.Json", @"Newtonsoft.Json.SerializationBinder");
            feature.AddKnownType(@"Newtonsoft.Json.TraceLevel,Newtonsoft.Json", @"Newtonsoft.Json.TraceLevel");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.MethodBinder,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.MethodBinder");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.MemberTypes,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.MemberTypes");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.BindingFlags,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.BindingFlags");
            feature.AddKnownType(@"Newtonsoft.Json.Serialization.FormatterConverter,Newtonsoft.Json", @"Newtonsoft.Json.Serialization.FormatterConverter");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.ConversationService,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.ConversationService");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.IConversationService,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.IConversationService");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CaptureGroup,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CaptureGroup");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Context,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Context");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Counterexample,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Counterexample");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CounterexampleCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CounterexampleCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateCounterexample,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateCounterexample");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateEntity,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateEntity");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateExample,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateExample");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateIntent,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateIntent");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateSynonym,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateSynonym");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateValue,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateValue");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateWorkspace,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateWorkspace");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeAction,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeAction");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Entity,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Entity");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.EntityCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.EntityCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.EntityExport,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.EntityExport");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Example,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Example");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ExampleCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ExampleCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.InputData,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.InputData");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Intent,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Intent");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IntentCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IntentCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IntentExport,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IntentExport");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogExport,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogExport");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogMessage,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogMessage");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogPagination,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogPagination");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageInput,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageInput");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageRequest,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageRequest");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageResponse,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.MessageResponse");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.OutputData,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.OutputData");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Pagination,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Pagination");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.RuntimeEntity,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.RuntimeEntity");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.RuntimeIntent,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.RuntimeIntent");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Synonym,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Synonym");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.SynonymCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.SynonymCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.SystemResponse,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.SystemResponse");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateCounterexample,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateCounterexample");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateEntity,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateEntity");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateExample,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateExample");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateIntent,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateIntent");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateSynonym,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateSynonym");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateValue,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateValue");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateWorkspace,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateWorkspace");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Value,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Value");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueExport,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueExport");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Workspace,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Workspace");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceCollection,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceCollection");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceExport,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceExport");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode+NodeTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode.NodeTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode+EventNameEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateDialogNode.EventNameEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateValue+ValueTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateValue.ValueTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode+NodeTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode.NodeTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode+EventNameEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode.EventNameEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeAction+ActionTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeAction.ActionTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep+BehaviorEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep.BehaviorEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep+SelectorEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNodeNextStep.SelectorEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogMessage+LevelEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.LogMessage.LevelEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode+NodeTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode.NodeTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode+EventNameEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode.EventNameEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateValue+ValueTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateValue.ValueTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.Value+ValueTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.Value.ValueTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueExport+ValueTypeEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.ValueExport.ValueTypeEnum");
            feature.AddKnownType(@"IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceExport+StatusEnum,IBM.WatsonDeveloperCloud.Conversation.v1", @"IBM.WatsonDeveloperCloud.Conversation.v1.Model.IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceExport.StatusEnum");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
