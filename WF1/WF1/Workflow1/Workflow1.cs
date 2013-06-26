using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WF1.Workflow1
{
    public sealed partial class Workflow1 : SequentialWorkflowActivity
    {
        private bool isFinished = false;

        public Workflow1()
        {
            InitializeComponent();
        }

        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public static DependencyProperty onWorkflowActivated1_Roles1Property = DependencyProperty.Register("onWorkflowActivated1_Roles1", typeof(System.Workflow.Activities.WorkflowRoleCollection), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Activity")]
        public WorkflowRoleCollection onWorkflowActivated1_Roles1
        {
            get
            {
                return ((System.Workflow.Activities.WorkflowRoleCollection)(base.GetValue(WF1.Workflow1.Workflow1.onWorkflowActivated1_Roles1Property)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.onWorkflowActivated1_Roles1Property, value);
            }
        }

        public static DependencyProperty onWorkflowActivated1_Invoked1Event = DependencyProperty.Register("onWorkflowActivated1_Invoked1", typeof(System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Handlers")]
        public event EventHandler<ExternalDataEventArgs> onWorkflowActivated1_Invoked1
        {
            add
            {
                base.AddHandler(onWorkflowActivated1_Invoked1Event, value);
            }
            remove
            {
                base.RemoveHandler(onWorkflowActivated1_Invoked1Event, value);
            }
        }


        public WFData WorkflowData
        {
            get
            {
                return (WFData)GetValue(WorkflowDataProperty);
            }
            set
            {
                SetValue(WorkflowDataProperty, value);
            }
        }

        public static readonly DependencyProperty WorkflowDataProperty =
            DependencyProperty.Register("WorkflowData", typeof(WFData), typeof(WF1.Workflow1.Workflow1));

        private void sendEmail1_MethodInvoking(object sender, EventArgs e)
        {

        }



        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {
            using (StringReader stringReader = new StringReader(workflowProperties.InitiationData))
            {
                using (XmlReader reader = XmlReader.Create(stringReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(WFData));
                    WorkflowData = (WFData)serializer.Deserialize(reader);
                }
            }

        }

        public static DependencyProperty task1ContentTypeId1Property = DependencyProperty.Register("task1ContentTypeId1", typeof(System.String), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String task1ContentTypeId1
        {
            get
            {
                return ((string)(base.GetValue(WF1.Workflow1.Workflow1.task1ContentTypeId1Property)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.task1ContentTypeId1Property, value);
            }
        }

        public static DependencyProperty task1GuidProperty = DependencyProperty.Register("task1Guid", typeof(System.Guid), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Guid task1Guid
        {
            get
            {
                return ((System.Guid)(base.GetValue(WF1.Workflow1.Workflow1.task1GuidProperty)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.task1GuidProperty, value);
            }
        }

        public static DependencyProperty task1PropertiesProperty = DependencyProperty.Register("task1Properties", typeof(Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public SPWorkflowTaskProperties task1Properties
        {
            get
            {
                return ((Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties)(base.GetValue(WF1.Workflow1.Workflow1.task1PropertiesProperty)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.task1PropertiesProperty, value);
            }
        }

        private void createTask1Invoke(object sender, EventArgs e)
        {
            task1Properties = new SPWorkflowTaskProperties();
            task1Guid = Guid.NewGuid();
            task1ContentTypeId1 = "0x01080100FFbc98c2529347a5886b8d2576b954ef";
        }

        public static DependencyProperty Task1Changed1_AfterPropertiesProperty = DependencyProperty.Register("Task1Changed1_AfterProperties", typeof(Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public SPWorkflowTaskProperties Task1Changed1_AfterProperties
        {
            get
            {
                return ((Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties)(base.GetValue(WF1.Workflow1.Workflow1.Task1Changed1_AfterPropertiesProperty)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.Task1Changed1_AfterPropertiesProperty, value);
            }
        }

        public static DependencyProperty Task1Changed1_BeforeProperties1Property = DependencyProperty.Register("Task1Changed1_BeforeProperties1", typeof(Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public SPWorkflowTaskProperties Task1Changed1_BeforeProperties1
        {
            get
            {
                return ((Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties)(base.GetValue(WF1.Workflow1.Workflow1.Task1Changed1_BeforeProperties1Property)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.Task1Changed1_BeforeProperties1Property, value);
            }
        }

        private void task1Changed1Invoke(object sender, ExternalDataEventArgs e)
        {
            isFinished = Task1Changed1_AfterProperties.PercentComplete == 1F;
        }

        private void while1Invoke(object sender, ConditionalEventArgs e)
        {
            e.Result = !isFinished;
        }

        public static DependencyProperty Task1Outcome1Property = DependencyProperty.Register("Task1Outcome1", typeof(System.String), typeof(WF1.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String Task1Outcome1
        {
            get
            {
                return ((string)(base.GetValue(WF1.Workflow1.Workflow1.Task1Outcome1Property)));
            }
            set
            {
                base.SetValue(WF1.Workflow1.Workflow1.Task1Outcome1Property, value);
            }
        }
    }
}
