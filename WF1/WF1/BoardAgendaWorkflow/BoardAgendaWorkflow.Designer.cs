using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace WF1
{
    public sealed partial class BoardAgendaWorkflow
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken6 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken7 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken8 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind21 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken9 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind22 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind23 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind24 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken10 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind25 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind26 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken11 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind27 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind28 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken12 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind29 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind30 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken13 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind31 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind32 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind33 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken14 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind34 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken15 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind35 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind36 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind37 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind38 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken16 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind39 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken17 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind40 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind41 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind42 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind43 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken18 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind44 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken19 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind45 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind46 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind47 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind48 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken20 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind49 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken21 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind50 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind51 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind52 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind53 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken22 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind54 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken23 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind55 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind56 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind57 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind58 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken24 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind59 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken25 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind60 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind61 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind62 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind63 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken26 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind64 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken27 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind65 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind66 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind67 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind68 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken28 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind69 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken29 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind70 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind71 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind72 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind73 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken30 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind74 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken31 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind75 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind76 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind77 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind78 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken32 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind79 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken33 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind80 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind81 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind82 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind83 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken34 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind84 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken35 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind85 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind86 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind87 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind88 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken36 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind89 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken37 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind90 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind91 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind92 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind93 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken38 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind94 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken39 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind95 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind96 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind97 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken40 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind98 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind99 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind100 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind101 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken41 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind102 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind103 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind104 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken42 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind105 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference6 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind106 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind107 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken43 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind108 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition7 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition8 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition9 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition10 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition11 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition12 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition13 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition14 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition15 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition16 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition17 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference7 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference8 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference9 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken44 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind109 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference10 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken45 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken46 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind110 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind111 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference11 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken47 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind112 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference12 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken48 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken49 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind113 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind114 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference13 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken50 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind115 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference14 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken51 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind116 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind117 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind118 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken52 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind119 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind120 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken53 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind121 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind122 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken54 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind123 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind124 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken55 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind125 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind126 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken56 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind127 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind128 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken57 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind129 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind130 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken58 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind131 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind132 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken59 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind133 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind134 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken60 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind135 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind136 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken61 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind137 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind138 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken62 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind139 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind140 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken63 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind141 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind142 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken64 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind143 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference15 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference16 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference17 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference18 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference19 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference20 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference21 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind144 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind145 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken65 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind146 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference22 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind147 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind148 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken66 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind149 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference23 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind150 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind151 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken67 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind152 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference24 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind153 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind154 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken68 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind155 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference25 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind156 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind157 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken69 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind158 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference26 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind159 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind160 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken70 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind161 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference27 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind162 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind163 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken71 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind164 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference28 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind165 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind166 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken72 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind167 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference29 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind168 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind169 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken73 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind170 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference30 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind171 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind172 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken74 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind173 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference31 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind174 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind175 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken75 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind176 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference32 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind177 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind178 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken76 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind179 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference33 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind180 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind181 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken77 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind182 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference34 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken78 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind183 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference35 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken79 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind184 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind185 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference36 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken80 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind186 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference37 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken81 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind187 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind188 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference38 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken82 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind189 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference39 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken83 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind190 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind191 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference40 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken84 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind192 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference41 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken85 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken86 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind193 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind194 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference42 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken87 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind195 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference43 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken88 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken89 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind196 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind197 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference44 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken90 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind198 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference45 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken91 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken92 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind199 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind200 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference46 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken93 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind201 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference47 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken94 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken95 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind202 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind203 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference48 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken96 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind204 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference49 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken97 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken98 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind205 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind206 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference50 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken99 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind207 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference51 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken100 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken101 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind208 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind209 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference52 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken102 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind210 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference53 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken103 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken104 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind211 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind212 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference54 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken105 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind213 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference55 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken106 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken107 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind214 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind215 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference56 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken108 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind216 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference57 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken109 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken110 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind217 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind218 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference58 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken111 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind219 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference59 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken112 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken113 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind220 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind221 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind222 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind223 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken114 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind224 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken115 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind225 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind226 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind227 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind228 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken116 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind229 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken117 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind230 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind231 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference60 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference61 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference62 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference63 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference64 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference65 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference66 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference67 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference68 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference69 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference70 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference71 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference72 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference73 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference74 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference75 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference76 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference77 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference78 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference79 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference80 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference81 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference82 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference83 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference84 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference85 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.CodeCondition codecondition18 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition19 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind232 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken118 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind233 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind234 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken119 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind235 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind236 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind237 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken120 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind238 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind239 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind240 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken121 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind241 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference86 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind242 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind243 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken122 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind244 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference87 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind245 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind246 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken123 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind247 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind248 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind249 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken124 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind250 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind251 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind252 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind253 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind254 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken125 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind255 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind256 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind257 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind258 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind259 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken126 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind260 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind261 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference88 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken127 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind262 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind263 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind264 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference89 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken128 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind265 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind266 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference90 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind267 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference91 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind268 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind269 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference92 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind270 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference93 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind271 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind272 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition20 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition21 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind273 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference94 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind274 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind275 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind276 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind277 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind278 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind279 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference95 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference96 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference97 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind280 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind281 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind282 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference98 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind283 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind284 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind285 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference99 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference100 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind286 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference101 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken129 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind287 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind288 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference102 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind289 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference103 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind290 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind291 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind292 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind293 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken130 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind294 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind295 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind296 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken131 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind297 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind298 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind299 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken132 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind300 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind301 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference104 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind302 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind303 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind304 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference105 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind305 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind306 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken133 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind307 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference106 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference107 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind308 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind309 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference108 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind310 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind311 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind312 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind314 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind313 = new System.Workflow.ComponentModel.ActivityBind();
            this.logToHistoryListActivity159 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity18 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity158 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity157 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onTaskChanged5 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateTask5 = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity156 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseBranchActivity40 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity39 = new System.Workflow.Activities.IfElseBranchActivity();
            this.logToHistoryListActivity135 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity15 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity134 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity133 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onTaskChanged3 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateTask2 = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity132 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity126 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity14 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity125 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity124 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onTaskChanged2 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateTask1 = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity123 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity117 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity13 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity116 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity115 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAdHocUser4TaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.adHocUser4TaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAdHocUser4reviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity114 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity19 = new System.Workflow.Activities.IfElseActivity();
            this.onTaskCreated5 = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity155 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseBranchActivity36 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity35 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity32 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity31 = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser4TaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser4TaskISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.sequenceActivity96 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity95 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity94 = new System.Workflow.Activities.SequenceActivity();
            this.onExecutiveDirectorReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.ifElseActivity16 = new System.Workflow.Activities.IfElseActivity();
            this.onTaskCreated2 = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity131 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity15 = new System.Workflow.Activities.IfElseActivity();
            this.onTaskCreated1 = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity122 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity14 = new System.Workflow.Activities.IfElseActivity();
            this.onAdHocUser4ReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity112 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity108 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity12 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity107 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity106 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAdHocUser3ReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.adHocUser3TaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAdHocUser3reviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity105 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity99 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity11 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity98 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity97 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAdHocUser2ReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.adHocUser2TaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAdHocUser2reviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity96 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity90 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity10 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity89 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity88 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAdHocUser1ReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.adHocUser1TaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAdHocUser1reviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity87 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity81 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity9 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity80 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity79 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMPoliceReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmPoliceReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMPoliceReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity78 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity72 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity8 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity71 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity70 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMCommunicationsReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmCommunicationsReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMCommunicationsReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity69 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity63 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity7 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity62 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity61 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMAuditReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmAuditReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMAuditReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity60 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity54 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity6 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity53 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity52 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMContractsReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmContractsReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMContractsReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity51 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity45 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity5 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity44 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity43 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMLegalReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmLegalReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMLegalReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity42 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity36 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity4 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity35 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity34 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMSafetyReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmSafetyReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMSafetyReviewExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity33 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity27 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity3 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity26 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity25 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMHumanResourcesTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmHumanResourcesTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMHumanResourcesTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity24 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity18 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity2 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity16 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onagmPlanningReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmPlanningReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMPlanningReviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity15 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity9 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity1 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity8 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity7 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMITReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmITReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMITReviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity6 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logAGMFinanceReviewDelayEnd = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivityForAGMFinanceReviewTask = new System.Workflow.Activities.DelayActivity();
            this.logAGMFinanceReviewDelayStart = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logAGMFinanceReviewTaskMarkedExpired = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onAGMFinanceReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmFinanceReviewTaskUpdate = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.codeAGMFinanceReviewTaskExpired = new System.Workflow.Activities.CodeActivity();
            this.logAGMFinanceReviewTaskExpired = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity154 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.conditionedActivityGroup5 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity153 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.executiveDirectorReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileActivity1 = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity152 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailExecutiveDirectorAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.executiveDirectorReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity151 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity82 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity81 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity80 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMRailOperationsReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity79 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity78 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity77 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMBusOperationsReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity76 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity75 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity74 = new System.Workflow.Activities.SequenceActivity();
            this.onAdHocUser4TaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.adHocUser3TaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser3TaskISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser2TaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser2TaskISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser1TaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.adHocUser1TaskISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmPoliceReviewIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmPoliceReviewISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmCommunicationsIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmCommunicationsReviewISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmAuditReviewTaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmAuditReviewTaskISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmContractsReviewIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmContractsReviewISOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity15 = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmLegalReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmSafetyReviewTaskIsNotOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmSafetyReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmHumanResourcesTaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmHumanResourcesTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmPlanningReviewTaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmPlanningReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmITReviewTaskIsNOTOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmITReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmFinanceReviewTaskIsNotOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.agmFinanceReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity38 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity37 = new System.Workflow.Activities.IfElseBranchActivity();
            this.logToHistoryListActivity130 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.conditionedActivityGroup2 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity129 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmRailOperationsReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMRailOperationsReviewTask = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity128 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMRailOpsAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmRailOperationsReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity127 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity121 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.conditionedActivityGroup1 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity120 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmBusOperationsReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMBusOperationsReviewTaskNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity119 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMBusOpsAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmBusOperationsReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity118 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity111 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAdHocUser4ReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity113 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser4ReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAdHocUser4ReviewTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity110 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser4ReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity109 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity13 = new System.Workflow.Activities.IfElseActivity();
            this.onAdHocUser3ReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity103 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity12 = new System.Workflow.Activities.IfElseActivity();
            this.onAdHocUser2ReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity94 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity11 = new System.Workflow.Activities.IfElseActivity();
            this.onAdhocUser1TaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity85 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity10 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMPoliceTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity76 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity8 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMCommunicationsReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity67 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity9 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMAuditReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity58 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity6 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMContractsReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity49 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity7 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMLegalReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity40 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMSafetyReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity31 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMHumanResourcesReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity22 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMPlanningReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity13 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.onAGMITReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity4 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifAGMReviewTaskOverdue = new System.Workflow.Activities.IfElseActivity();
            this.onAGMFinanceReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logAGMFinanceReviewTaskCreatedInSequence = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseExecutiveDirectorSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseBranchActivity34 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity33 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity30 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity29 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity28 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity27 = new System.Workflow.Activities.IfElseBranchActivity();
            this.sequenceActivity73 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity72 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity71 = new System.Workflow.Activities.SequenceActivity();
            this.onAdHocUser3TaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity70 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity69 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity68 = new System.Workflow.Activities.SequenceActivity();
            this.onAdHocUser2ReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity67 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity66 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity65 = new System.Workflow.Activities.SequenceActivity();
            this.onAdHocUser1ReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity64 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity63 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity62 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMPoliceReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity61 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity60 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity59 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMCommunicationsReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity58 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity57 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity56 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMAuditReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity55 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity54 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity53 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMContractsReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity52 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity51 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity50 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMLegalReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity49 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity48 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity47 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMSafetyReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity46 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity45 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity44 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMHumanResourcesReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity43 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity42 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity41 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMPlanningTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity40 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity39 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity38 = new System.Workflow.Activities.SequenceActivity();
            this.onAGMITReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.agmFinanceReviewDueDateMonitorSequence = new System.Workflow.Activities.SequenceActivity();
            this.agmReviewTaskCompletedSequence = new System.Workflow.Activities.SequenceActivity();
            this.agmReviewTaskCreatedSequence = new System.Workflow.Activities.SequenceActivity();
            this.onAGMFinanceReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity93 = new System.Workflow.Activities.SequenceActivity();
            this.ifElseAGMRailOperationsSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMBusOperationsSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAdHocUser4Selected = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity102 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAdHocUser3ReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity104 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser3ReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAdHocUser3ReviewTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity101 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser3ReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity100 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity93 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAdHocUser2ReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity95 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser2ReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAdHocUser2ReviewTaskNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity92 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser2ReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity91 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity84 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAdHocUser1ReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity86 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser1ReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAdhocUser1ReviewTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity83 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.adHocUser1ReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity82 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity75 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMPoliceReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity77 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmPoliceReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMPoliceReviewTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity74 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMPoliceAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmPoliceReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity73 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity66 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMCommunicationsReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity68 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmCommunicationsTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMCommunicationsTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity65 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMCommunicationsAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmCommunicationsReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity64 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity57 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMAuditReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity59 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmAuditReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMAuditReviewTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity56 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMAudit = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmAuditReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity55 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity48 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMContractsReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity50 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmContractsReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMContractsReviewIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity47 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMContracts = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmContractsReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity46 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity39 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMLegalReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity41 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmLegalReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMLegalReviewIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity38 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMLegalAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmLegalReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity37 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity30 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGForSafetyReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity32 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmSafetyReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMSafetyReviewIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity29 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMSafetyAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmSafetyReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity28 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity21 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGForAGMHumanResourcesReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity23 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmHumanResourcesReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMHumanResourcesTaskNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity20 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailHumanResourcesAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmHumanResourcesReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity19 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity12 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGForAGMPlanningReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity14 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmPlanningReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMPlanningReviewTaskNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity11 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMPlanningAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmPlanningReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity10 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity3 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGM_ITReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity5 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmITReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMITReviewIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMITAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmITReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logAGMFinanceNotSelected = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.CAGforAGMFinanceReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logAGMFinanceReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.agmFinanceReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMFinanceReviewIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logAGMFinanceReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmailAGMFinanceAdmin = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.agmFinanceReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logAGMFinanceSelected = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity148 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity17 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity147 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity146 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onTaskChanged6 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateTask4 = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.logToHistoryListActivity142 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayActivity16 = new System.Workflow.Activities.DelayActivity();
            this.logToHistoryListActivity141 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity140 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onTaskChanged4 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateTask3 = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.sequenceActivity37 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity36 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity35 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity34 = new System.Workflow.Activities.SequenceActivity();
            this.ifElseBranchActivity26 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity25 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity24 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity23 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity22 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity21 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity20 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity19 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity16 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity14 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity18 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity17 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity11 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity10 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity13 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity12 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity7 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity6 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity9 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity8 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity5 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity4 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity3 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifReviewRequired = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity44 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity43 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity42 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity41 = new System.Workflow.Activities.IfElseBranchActivity();
            this.parallelActivity17 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity16 = new System.Workflow.Activities.ParallelActivity();
            this.ifElseAdHocUser3Selected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAdHocUser2Selected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAdHocUser1Selected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMPoliceSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMCommunicationsSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMAuditSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMContractsSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMLegalIsSelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMSafetySelected = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMHumanResourcesReviewRequired = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMPlanningReviewRequired = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGM_ITReviewRequired = new System.Workflow.Activities.IfElseActivity();
            this.ifElseAGMFinanceReviewRequired = new System.Workflow.Activities.IfElseActivity();
            this.ifElseActivity17 = new System.Workflow.Activities.IfElseActivity();
            this.onTaskCreated4 = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity145 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.onTaskCreated3 = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logToHistoryListActivity139 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity33 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity32 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity31 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity30 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity29 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity28 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity27 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity26 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity24 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity23 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity22 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity21 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity20 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity19 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity18 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity17 = new System.Workflow.Activities.SequenceActivity();
            this.onCBSSReReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.onDGMReReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity92 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity91 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity90 = new System.Workflow.Activities.SequenceActivity();
            this.onExpeditedCBSSReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity88 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity87 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity86 = new System.Workflow.Activities.SequenceActivity();
            this.onexpeditedDGMReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.delaySPSSReviewTaskIsDueCheck = new System.Workflow.Activities.DelayActivity();
            this.logSPSSReviewTaskExpired = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onSPSSReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateSPSSReviewTaskToExpired = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.logDGMReviewTaskDelayAwaken = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.delayAGMApproveTaskIsDueCheck = new System.Workflow.Activities.DelayActivity();
            this.logBeforeDGMReviewTaskDelay = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logDGMReviewTaskExpired = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onDGMReviewTaskUpdated = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.updateDGMReviewTaskToExpired = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.parallelActivity15 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity14 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity13 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity12 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity11 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity10 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity9 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity8 = new System.Workflow.Activities.ParallelActivity();
            this.onGMReApproveTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.logToHistoryListActivity163 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.completeCBSSReReviewTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileActivity4 = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity162 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail2 = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.ReApproveTaskForCBSS = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity161 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.completeDGMReReviewTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileActivity3 = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity160 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail1 = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.ReApproveTaskForDGM = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.conditionedActivityGroup4 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity144 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.expeditedCBSSReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileCBSSReviewTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity143 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.expeditedCBSSReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.conditionedActivityGroup3 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logToHistoryListActivity138 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.expeditedDGMReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileDGMReviewTaskNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity137 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.expeditedDGMReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.SPSSReviewTaskIsNotOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.SPSSReviewTaskIsOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.DGMReviewTaskIsNotOverdue = new System.Workflow.Activities.IfElseBranchActivity();
            this.DGMReviewTaskIsOverDue = new System.Workflow.Activities.IfElseBranchActivity();
            this.sequenceActivity16 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity15 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity14 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity13 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity12 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity11 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity10 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity9 = new System.Workflow.Activities.SequenceActivity();
            this.completeGMReApproveTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileGMReApproveTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logToHistoryListActivity165 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.GMReApproveTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.sequenceActivity99 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity98 = new System.Workflow.Activities.SequenceActivity();
            this.logToHistoryListActivity150 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity89 = new System.Workflow.Activities.SequenceActivity();
            this.logToHistoryListActivity149 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity85 = new System.Workflow.Activities.SequenceActivity();
            this.ifElseSPSSReviewTaskIsOverdue = new System.Workflow.Activities.IfElseActivity();
            this.onSPSSReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logInSPSSReviewTaskCreatedSequence = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseDGMReviewTaskIsOverDue = new System.Workflow.Activities.IfElseActivity();
            this.onDGMReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.OnTaskCreated();
            this.logInDGMReviewTaskSequence = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.parallelActivity7 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity6 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity5 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity4 = new System.Workflow.Activities.ParallelActivity();
            this.logToHistoryListActivity164 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity100 = new System.Workflow.Activities.SequenceActivity();
            this.parallelActivity19 = new System.Workflow.Activities.ParallelActivity();
            this.notifyAgendaOwnerAboutComments = new CustomActivities.NotifyAgendaOwner();
            this.codeInitializeAgendaOwnerTask = new System.Workflow.Activities.CodeActivity();
            this.ifElseCBSSNotSelected = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseCBSSSelected = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseDGMNOTSelected = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseDGMSelected = new System.Workflow.Activities.IfElseBranchActivity();
            this.sequenceSPSSReviewTaskDelay = new System.Workflow.Activities.SequenceActivity();
            this.sequenceSPSSReviewTaskCompleted = new System.Workflow.Activities.SequenceActivity();
            this.sequenceSPSSReviewTaskCreated = new System.Workflow.Activities.SequenceActivity();
            this.onSPSSReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceDGMApproveTaskOverdue = new System.Workflow.Activities.SequenceActivity();
            this.sequenceDGMReviewTaskCompleted = new System.Workflow.Activities.SequenceActivity();
            this.sequenceDGMReviewTaskCreated = new System.Workflow.Activities.SequenceActivity();
            this.onDGMReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity8 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity7 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity6 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity5 = new System.Workflow.Activities.SequenceActivity();
            this.ifElseBranchActivity46 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity45 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseExpeditedCBSS = new System.Workflow.Activities.IfElseActivity();
            this.ifElseExpeditedDGM = new System.Workflow.Activities.IfElseActivity();
            this.CAGForSPSSReviewTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logSPSSReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SPSSReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileSPSSReviewTaskNotComplted = new System.Workflow.Activities.WhileActivity();
            this.logSPSSReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendCBSSApproveTaskEmail = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.SPSSReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.CAGForDGMApproveTask = new System.Workflow.Activities.ConditionedActivityGroup();
            this.logDGMReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.DGMReviewTaskCompleted = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileAGMReviewTaskNotCompleted = new System.Workflow.Activities.WhileActivity();
            this.logDGMReviewTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendDGMApproveTaskEmail = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.DGMApproveTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.parallelActivity3 = new System.Workflow.Activities.ParallelActivity();
            this.parallelActivity2 = new System.Workflow.Activities.ParallelActivity();
            this.ifElseActivity18 = new System.Workflow.Activities.IfElseActivity();
            this.sequenceActivity84 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity83 = new System.Workflow.Activities.SequenceActivity();
            this.onSubmitForGMApprovalTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity2 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.onSubmitForDGMApprovalTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity4 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity3 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity97 = new System.Workflow.Activities.SequenceActivity();
            this.onGMApproveTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.parallelActivity18 = new System.Workflow.Activities.ParallelActivity();
            this.logToHistoryListActivity136 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeSetAgendaToExpeditedWFStarted = new System.Workflow.Activities.CodeActivity();
            this.codeSetAgendaStatusToSubmittedForGMApproval = new System.Workflow.Activities.CodeActivity();
            this.logSubmitToGMApprovalTaskComplete = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.completeSubmtToGMApprovalTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileSubmitToGMApprovalTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.logGMApprovalTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SubmitForGMApprovalTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logAgendaStatusSetToDGMReviewCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeSetAgendaStatusToDGMApproved = new System.Workflow.Activities.CodeActivity();
            this.parallelDGMandSPSSApproval = new System.Workflow.Activities.ParallelActivity();
            this.logDGMApprovalTaskCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SubmitForDGMApprovalTaskComplete = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileDGMApprovalTaskIncomplete = new System.Workflow.Activities.WhileActivity();
            this.logSubmitForDGMApprovalTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SubmitForDGMandSPSSReviewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logAgendaStatusChangedToStakeHolderReviewCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeSetAgendaStatusToStakeHolderReviewsComplete = new System.Workflow.Activities.CodeActivity();
            this.parallelActivity1 = new System.Workflow.Activities.ParallelActivity();
            this.codeSetAgendaStatusToPublished = new System.Workflow.Activities.CodeActivity();
            this.logDocSetCopied = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeCopyDocSetToBoard = new System.Workflow.Activities.CodeActivity();
            this.logGMApproveTaskCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.GMApproveTaskComplete = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileGMApproveTaskIsNotApproved = new System.Workflow.Activities.WhileActivity();
            this.whileGMApproveTaskIsNOTComplete = new System.Workflow.Activities.WhileActivity();
            this.logGMApproveTaskCreated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.GMApproveTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.ifExpedited = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNormal = new System.Workflow.Activities.IfElseBranchActivity();
            this.notifyAgendaOwner = new CustomActivities.NotifyAgendaOwner();
            this.logWorkflowCompleted = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sequenceActivity25 = new System.Workflow.Activities.SequenceActivity();
            this.ifElseExpedited = new System.Workflow.Activities.IfElseActivity();
            this.sendEmailToCommitteeCoordinators = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logStatusForAgendaChanged = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeSetAgendaStatusToPublishedForReview = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // logToHistoryListActivity159
            // 
            this.logToHistoryListActivity159.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity159.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity159.HistoryDescription = "AGMFinanceReview Delay End";
            this.logToHistoryListActivity159.HistoryOutcome = "";
            this.logToHistoryListActivity159.Name = "logToHistoryListActivity159";
            this.logToHistoryListActivity159.OtherData = "";
            this.logToHistoryListActivity159.UserId = -1;
            // 
            // delayActivity18
            // 
            this.delayActivity18.Name = "delayActivity18";
            this.delayActivity18.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity158
            // 
            this.logToHistoryListActivity158.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity158.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity158.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logToHistoryListActivity158.HistoryOutcome = "";
            this.logToHistoryListActivity158.Name = "logToHistoryListActivity158";
            this.logToHistoryListActivity158.OtherData = "";
            this.logToHistoryListActivity158.UserId = -1;
            // 
            // logToHistoryListActivity157
            // 
            this.logToHistoryListActivity157.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity157.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity157.HistoryDescription = "AGM Finance Review marked expired by system";
            this.logToHistoryListActivity157.HistoryOutcome = "";
            this.logToHistoryListActivity157.Name = "logToHistoryListActivity157";
            this.logToHistoryListActivity157.OtherData = "";
            this.logToHistoryListActivity157.UserId = -1;
            // 
            // onTaskChanged5
            // 
            activitybind1.Name = "BoardAgendaWorkflow";
            activitybind1.Path = "onAGMFinanceReviewTaskUpdated_AfterProperties";
            activitybind2.Name = "BoardAgendaWorkflow";
            activitybind2.Path = "onAGMFinanceReviewTaskUpdated_BeforeProperties";
            correlationtoken1.Name = "agmFinanceReviewTask";
            correlationtoken1.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskChanged5.CorrelationToken = correlationtoken1;
            this.onTaskChanged5.Executor = null;
            this.onTaskChanged5.Name = "onTaskChanged5";
            activitybind3.Name = "BoardAgendaWorkflow";
            activitybind3.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskChanged5.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.onTaskChanged5.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.onTaskChanged5.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // updateTask5
            // 
            correlationtoken2.Name = "agmFinanceReviewTask";
            correlationtoken2.OwnerActivityName = "BoardAgendaWorkflow";
            this.updateTask5.CorrelationToken = correlationtoken2;
            this.updateTask5.Name = "updateTask5";
            activitybind4.Name = "BoardAgendaWorkflow";
            activitybind4.Path = "agmFinanceReviewTask_TaskId";
            activitybind5.Name = "BoardAgendaWorkflow";
            activitybind5.Path = "agmFinanceReviewTaskUpdate_TaskProperties";
            this.updateTask5.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.updateTask5.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeAGMFinanceReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity156
            // 
            this.logToHistoryListActivity156.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity156.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity156.HistoryDescription = "";
            this.logToHistoryListActivity156.HistoryOutcome = "";
            this.logToHistoryListActivity156.Name = "logToHistoryListActivity156";
            this.logToHistoryListActivity156.OtherData = "";
            this.logToHistoryListActivity156.UserId = -1;
            // 
            // ifElseBranchActivity40
            // 
            this.ifElseBranchActivity40.Activities.Add(this.logToHistoryListActivity158);
            this.ifElseBranchActivity40.Activities.Add(this.delayActivity18);
            this.ifElseBranchActivity40.Activities.Add(this.logToHistoryListActivity159);
            this.ifElseBranchActivity40.Name = "ifElseBranchActivity40";
            // 
            // ifElseBranchActivity39
            // 
            this.ifElseBranchActivity39.Activities.Add(this.logToHistoryListActivity156);
            this.ifElseBranchActivity39.Activities.Add(this.codeActivity3);
            this.ifElseBranchActivity39.Activities.Add(this.updateTask5);
            this.ifElseBranchActivity39.Activities.Add(this.onTaskChanged5);
            this.ifElseBranchActivity39.Activities.Add(this.logToHistoryListActivity157);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMFinanceReviewTaskOverDue);
            this.ifElseBranchActivity39.Condition = codecondition1;
            this.ifElseBranchActivity39.Name = "ifElseBranchActivity39";
            // 
            // logToHistoryListActivity135
            // 
            this.logToHistoryListActivity135.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity135.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity135.HistoryDescription = "AGMFinanceReview Delay End";
            this.logToHistoryListActivity135.HistoryOutcome = "";
            this.logToHistoryListActivity135.Name = "logToHistoryListActivity135";
            this.logToHistoryListActivity135.OtherData = "";
            this.logToHistoryListActivity135.UserId = -1;
            // 
            // delayActivity15
            // 
            this.delayActivity15.Name = "delayActivity15";
            this.delayActivity15.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity134
            // 
            this.logToHistoryListActivity134.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity134.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity134.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logToHistoryListActivity134.HistoryOutcome = "";
            this.logToHistoryListActivity134.Name = "logToHistoryListActivity134";
            this.logToHistoryListActivity134.OtherData = "";
            this.logToHistoryListActivity134.UserId = -1;
            // 
            // logToHistoryListActivity133
            // 
            this.logToHistoryListActivity133.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity133.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity133.HistoryDescription = "AGM Finance Review marked expired by system";
            this.logToHistoryListActivity133.HistoryOutcome = "";
            this.logToHistoryListActivity133.Name = "logToHistoryListActivity133";
            this.logToHistoryListActivity133.OtherData = "";
            this.logToHistoryListActivity133.UserId = -1;
            // 
            // onTaskChanged3
            // 
            activitybind6.Name = "BoardAgendaWorkflow";
            activitybind6.Path = "onAGMFinanceReviewTaskUpdated_AfterProperties";
            activitybind7.Name = "BoardAgendaWorkflow";
            activitybind7.Path = "onAGMFinanceReviewTaskUpdated_BeforeProperties";
            correlationtoken3.Name = "agmFinanceReviewTask";
            correlationtoken3.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskChanged3.CorrelationToken = correlationtoken3;
            this.onTaskChanged3.Executor = null;
            this.onTaskChanged3.Name = "onTaskChanged3";
            activitybind8.Name = "BoardAgendaWorkflow";
            activitybind8.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            // 
            // updateTask2
            // 
            correlationtoken4.Name = "agmFinanceReviewTask";
            correlationtoken4.OwnerActivityName = "BoardAgendaWorkflow";
            this.updateTask2.CorrelationToken = correlationtoken4;
            this.updateTask2.Name = "updateTask2";
            activitybind9.Name = "BoardAgendaWorkflow";
            activitybind9.Path = "agmFinanceReviewTask_TaskId";
            activitybind10.Name = "BoardAgendaWorkflow";
            activitybind10.Path = "agmFinanceReviewTaskUpdate_TaskProperties";
            this.updateTask2.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.updateTask2.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeAGMFinanceReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity132
            // 
            this.logToHistoryListActivity132.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity132.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity132.HistoryDescription = "";
            this.logToHistoryListActivity132.HistoryOutcome = "";
            this.logToHistoryListActivity132.Name = "logToHistoryListActivity132";
            this.logToHistoryListActivity132.OtherData = "";
            this.logToHistoryListActivity132.UserId = -1;
            // 
            // logToHistoryListActivity126
            // 
            this.logToHistoryListActivity126.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity126.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity126.HistoryDescription = "AGMFinanceReview Delay End";
            this.logToHistoryListActivity126.HistoryOutcome = "";
            this.logToHistoryListActivity126.Name = "logToHistoryListActivity126";
            this.logToHistoryListActivity126.OtherData = "";
            this.logToHistoryListActivity126.UserId = -1;
            // 
            // delayActivity14
            // 
            this.delayActivity14.Name = "delayActivity14";
            this.delayActivity14.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity125
            // 
            this.logToHistoryListActivity125.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity125.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity125.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logToHistoryListActivity125.HistoryOutcome = "";
            this.logToHistoryListActivity125.Name = "logToHistoryListActivity125";
            this.logToHistoryListActivity125.OtherData = "";
            this.logToHistoryListActivity125.UserId = -1;
            // 
            // logToHistoryListActivity124
            // 
            this.logToHistoryListActivity124.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity124.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity124.HistoryDescription = "AGM Finance Review marked expired by system";
            this.logToHistoryListActivity124.HistoryOutcome = "";
            this.logToHistoryListActivity124.Name = "logToHistoryListActivity124";
            this.logToHistoryListActivity124.OtherData = "";
            this.logToHistoryListActivity124.UserId = -1;
            // 
            // onTaskChanged2
            // 
            activitybind11.Name = "BoardAgendaWorkflow";
            activitybind11.Path = "onAGMFinanceReviewTaskUpdated_AfterProperties";
            activitybind12.Name = "BoardAgendaWorkflow";
            activitybind12.Path = "onAGMFinanceReviewTaskUpdated_BeforeProperties";
            correlationtoken5.Name = "agmFinanceReviewTask";
            correlationtoken5.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskChanged2.CorrelationToken = correlationtoken5;
            this.onTaskChanged2.Executor = null;
            this.onTaskChanged2.Name = "onTaskChanged2";
            activitybind13.Name = "BoardAgendaWorkflow";
            activitybind13.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            // 
            // updateTask1
            // 
            correlationtoken6.Name = "agmFinanceReviewTask";
            correlationtoken6.OwnerActivityName = "BoardAgendaWorkflow";
            this.updateTask1.CorrelationToken = correlationtoken6;
            this.updateTask1.Name = "updateTask1";
            activitybind14.Name = "BoardAgendaWorkflow";
            activitybind14.Path = "agmFinanceReviewTask_TaskId";
            activitybind15.Name = "BoardAgendaWorkflow";
            activitybind15.Path = "agmFinanceReviewTaskUpdate_TaskProperties";
            this.updateTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
            this.updateTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeAGMFinanceReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity123
            // 
            this.logToHistoryListActivity123.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity123.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity123.HistoryDescription = "";
            this.logToHistoryListActivity123.HistoryOutcome = "";
            this.logToHistoryListActivity123.Name = "logToHistoryListActivity123";
            this.logToHistoryListActivity123.OtherData = "";
            this.logToHistoryListActivity123.UserId = -1;
            // 
            // logToHistoryListActivity117
            // 
            this.logToHistoryListActivity117.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity117.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity117.HistoryDescription = "AdHocUser4 Review Delay End";
            this.logToHistoryListActivity117.HistoryOutcome = "";
            this.logToHistoryListActivity117.Name = "logToHistoryListActivity117";
            this.logToHistoryListActivity117.OtherData = "";
            this.logToHistoryListActivity117.UserId = -1;
            // 
            // delayActivity13
            // 
            this.delayActivity13.Name = "delayActivity13";
            this.delayActivity13.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity116
            // 
            this.logToHistoryListActivity116.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity116.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity116.HistoryDescription = "AdHoc User 4 Review Delay Start";
            this.logToHistoryListActivity116.HistoryOutcome = "";
            this.logToHistoryListActivity116.Name = "logToHistoryListActivity116";
            this.logToHistoryListActivity116.OtherData = "";
            this.logToHistoryListActivity116.UserId = -1;
            // 
            // logToHistoryListActivity115
            // 
            this.logToHistoryListActivity115.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity115.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity115.HistoryDescription = "AdHoc User3 Review marked expired by system";
            this.logToHistoryListActivity115.HistoryOutcome = "";
            this.logToHistoryListActivity115.Name = "logToHistoryListActivity115";
            this.logToHistoryListActivity115.OtherData = "";
            this.logToHistoryListActivity115.UserId = -1;
            // 
            // onAdHocUser4TaskUpdated
            // 
            activitybind16.Name = "BoardAgendaWorkflow";
            activitybind16.Path = "onAdHocUser4TaskUpdated_AfterProperties";
            activitybind17.Name = "BoardAgendaWorkflow";
            activitybind17.Path = "onAdHocUser4TaskUpdated_BeforeProperties";
            correlationtoken7.Name = "adHocUser4ReviewTask";
            correlationtoken7.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser4TaskUpdated.CorrelationToken = correlationtoken7;
            this.onAdHocUser4TaskUpdated.Executor = null;
            this.onAdHocUser4TaskUpdated.Name = "onAdHocUser4TaskUpdated";
            activitybind18.Name = "BoardAgendaWorkflow";
            activitybind18.Path = "adHocUser4ReviewTask_TaskId";
            this.onAdHocUser4TaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdHocUser4ReviewTaskUpdated_Invoked);
            this.onAdHocUser4TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind17)));
            this.onAdHocUser4TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind18)));
            this.onAdHocUser4TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            // 
            // adHocUser4TaskUpdated
            // 
            correlationtoken8.Name = "adHocUser4ReviewTask";
            correlationtoken8.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser4TaskUpdated.CorrelationToken = correlationtoken8;
            this.adHocUser4TaskUpdated.Name = "adHocUser4TaskUpdated";
            activitybind19.Name = "BoardAgendaWorkflow";
            activitybind19.Path = "adHocUser4ReviewTask_TaskId";
            activitybind20.Name = "BoardAgendaWorkflow";
            activitybind20.Path = "adHocUser4TaskUpdated_TaskProperties";
            this.adHocUser4TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind20)));
            this.adHocUser4TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind19)));
            // 
            // codeAdHocUser4reviewTaskExpired
            // 
            this.codeAdHocUser4reviewTaskExpired.Name = "codeAdHocUser4reviewTaskExpired";
            this.codeAdHocUser4reviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAdHocUser4reviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity114
            // 
            this.logToHistoryListActivity114.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity114.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity114.HistoryDescription = "AdHoc User3 Task is Overdue";
            this.logToHistoryListActivity114.HistoryOutcome = "";
            this.logToHistoryListActivity114.Name = "logToHistoryListActivity114";
            this.logToHistoryListActivity114.OtherData = "";
            this.logToHistoryListActivity114.UserId = -1;
            // 
            // ifElseActivity19
            // 
            this.ifElseActivity19.Activities.Add(this.ifElseBranchActivity39);
            this.ifElseActivity19.Activities.Add(this.ifElseBranchActivity40);
            this.ifElseActivity19.Name = "ifElseActivity19";
            // 
            // onTaskCreated5
            // 
            activitybind21.Name = "BoardAgendaWorkflow";
            activitybind21.Path = "onAGMFinanceReviewTaskCreated_AfterProperties";
            correlationtoken9.Name = "agmFinanceReviewTask";
            correlationtoken9.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskCreated5.CorrelationToken = correlationtoken9;
            this.onTaskCreated5.Executor = null;
            this.onTaskCreated5.Name = "onTaskCreated5";
            activitybind22.Name = "BoardAgendaWorkflow";
            activitybind22.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskCreated5.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMFinanceReviewTaskCreated_Invoked);
            this.onTaskCreated5.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind22)));
            this.onTaskCreated5.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind21)));
            // 
            // logToHistoryListActivity155
            // 
            this.logToHistoryListActivity155.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity155.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity155.HistoryDescription = "Creating AGM Finance Review Task";
            this.logToHistoryListActivity155.HistoryOutcome = "";
            this.logToHistoryListActivity155.Name = "logToHistoryListActivity155";
            this.logToHistoryListActivity155.OtherData = "";
            this.logToHistoryListActivity155.UserId = -1;
            // 
            // ifElseBranchActivity36
            // 
            this.ifElseBranchActivity36.Activities.Add(this.logToHistoryListActivity134);
            this.ifElseBranchActivity36.Activities.Add(this.delayActivity15);
            this.ifElseBranchActivity36.Activities.Add(this.logToHistoryListActivity135);
            this.ifElseBranchActivity36.Name = "ifElseBranchActivity36";
            // 
            // ifElseBranchActivity35
            // 
            this.ifElseBranchActivity35.Activities.Add(this.logToHistoryListActivity132);
            this.ifElseBranchActivity35.Activities.Add(this.codeActivity2);
            this.ifElseBranchActivity35.Activities.Add(this.updateTask2);
            this.ifElseBranchActivity35.Activities.Add(this.onTaskChanged3);
            this.ifElseBranchActivity35.Activities.Add(this.logToHistoryListActivity133);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMFinanceReviewTaskOverDue);
            this.ifElseBranchActivity35.Condition = codecondition2;
            this.ifElseBranchActivity35.Name = "ifElseBranchActivity35";
            // 
            // ifElseBranchActivity32
            // 
            this.ifElseBranchActivity32.Activities.Add(this.logToHistoryListActivity125);
            this.ifElseBranchActivity32.Activities.Add(this.delayActivity14);
            this.ifElseBranchActivity32.Activities.Add(this.logToHistoryListActivity126);
            this.ifElseBranchActivity32.Name = "ifElseBranchActivity32";
            // 
            // ifElseBranchActivity31
            // 
            this.ifElseBranchActivity31.Activities.Add(this.logToHistoryListActivity123);
            this.ifElseBranchActivity31.Activities.Add(this.codeActivity1);
            this.ifElseBranchActivity31.Activities.Add(this.updateTask1);
            this.ifElseBranchActivity31.Activities.Add(this.onTaskChanged2);
            this.ifElseBranchActivity31.Activities.Add(this.logToHistoryListActivity124);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMFinanceReviewTaskOverDue);
            this.ifElseBranchActivity31.Condition = codecondition3;
            this.ifElseBranchActivity31.Name = "ifElseBranchActivity31";
            // 
            // adHocUser4TaskIsNOTOverdue
            // 
            this.adHocUser4TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity116);
            this.adHocUser4TaskIsNOTOverdue.Activities.Add(this.delayActivity13);
            this.adHocUser4TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity117);
            this.adHocUser4TaskIsNOTOverdue.Name = "adHocUser4TaskIsNOTOverdue";
            // 
            // adHocUser4TaskISOverdue
            // 
            this.adHocUser4TaskISOverdue.Activities.Add(this.logToHistoryListActivity114);
            this.adHocUser4TaskISOverdue.Activities.Add(this.codeAdHocUser4reviewTaskExpired);
            this.adHocUser4TaskISOverdue.Activities.Add(this.adHocUser4TaskUpdated);
            this.adHocUser4TaskISOverdue.Activities.Add(this.onAdHocUser4TaskUpdated);
            this.adHocUser4TaskISOverdue.Activities.Add(this.logToHistoryListActivity115);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAdHocUser4ReviewTaskOverDue);
            this.adHocUser4TaskISOverdue.Condition = codecondition4;
            this.adHocUser4TaskISOverdue.Name = "adHocUser4TaskISOverdue";
            ruleconditionreference1.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // sequenceActivity96
            // 
            this.sequenceActivity96.Activities.Add(this.ifElseActivity19);
            this.sequenceActivity96.Name = "sequenceActivity96";
            this.sequenceActivity96.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference1);
            // 
            // sequenceActivity95
            // 
            this.sequenceActivity95.Name = "sequenceActivity95";
            // 
            // sequenceActivity94
            // 
            this.sequenceActivity94.Activities.Add(this.logToHistoryListActivity155);
            this.sequenceActivity94.Activities.Add(this.onTaskCreated5);
            this.sequenceActivity94.Name = "sequenceActivity94";
            // 
            // onExecutiveDirectorReviewTaskChanged
            // 
            activitybind23.Name = "BoardAgendaWorkflow";
            activitybind23.Path = "onExecutiveDirectorReviewTaskChanged_AfterProperties";
            activitybind24.Name = "BoardAgendaWorkflow";
            activitybind24.Path = "onExecutiveDirectorReviewTaskChanged_BeforeProperties";
            correlationtoken10.Name = "executiveDirectorReviewTask";
            correlationtoken10.OwnerActivityName = "BoardAgendaWorkflow";
            this.onExecutiveDirectorReviewTaskChanged.CorrelationToken = correlationtoken10;
            this.onExecutiveDirectorReviewTaskChanged.Executor = null;
            this.onExecutiveDirectorReviewTaskChanged.Name = "onExecutiveDirectorReviewTaskChanged";
            activitybind25.Name = "BoardAgendaWorkflow";
            activitybind25.Path = "executiveDirectorReviewTask_TaskId";
            this.onExecutiveDirectorReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onExecutiveDirectorReviewTaskChanged_Invoked);
            this.onExecutiveDirectorReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind24)));
            this.onExecutiveDirectorReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind25)));
            this.onExecutiveDirectorReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind23)));
            // 
            // ifElseActivity16
            // 
            this.ifElseActivity16.Activities.Add(this.ifElseBranchActivity35);
            this.ifElseActivity16.Activities.Add(this.ifElseBranchActivity36);
            this.ifElseActivity16.Name = "ifElseActivity16";
            // 
            // onTaskCreated2
            // 
            activitybind26.Name = "BoardAgendaWorkflow";
            activitybind26.Path = "onAGMFinanceReviewTaskCreated_AfterProperties";
            correlationtoken11.Name = "agmFinanceReviewTask";
            correlationtoken11.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskCreated2.CorrelationToken = correlationtoken11;
            this.onTaskCreated2.Executor = null;
            this.onTaskCreated2.Name = "onTaskCreated2";
            activitybind27.Name = "BoardAgendaWorkflow";
            activitybind27.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskCreated2.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMFinanceReviewTaskCreated_Invoked);
            this.onTaskCreated2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind27)));
            this.onTaskCreated2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind26)));
            // 
            // logToHistoryListActivity131
            // 
            this.logToHistoryListActivity131.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity131.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity131.HistoryDescription = "Creating AGM Finance Review Task";
            this.logToHistoryListActivity131.HistoryOutcome = "";
            this.logToHistoryListActivity131.Name = "logToHistoryListActivity131";
            this.logToHistoryListActivity131.OtherData = "";
            this.logToHistoryListActivity131.UserId = -1;
            // 
            // ifElseActivity15
            // 
            this.ifElseActivity15.Activities.Add(this.ifElseBranchActivity31);
            this.ifElseActivity15.Activities.Add(this.ifElseBranchActivity32);
            this.ifElseActivity15.Name = "ifElseActivity15";
            // 
            // onTaskCreated1
            // 
            activitybind28.Name = "BoardAgendaWorkflow";
            activitybind28.Path = "onAGMFinanceReviewTaskCreated_AfterProperties";
            correlationtoken12.Name = "agmFinanceReviewTask";
            correlationtoken12.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskCreated1.CorrelationToken = correlationtoken12;
            this.onTaskCreated1.Executor = null;
            this.onTaskCreated1.Name = "onTaskCreated1";
            activitybind29.Name = "BoardAgendaWorkflow";
            activitybind29.Path = "agmFinanceReviewTask_TaskId";
            this.onTaskCreated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMFinanceReviewTaskCreated_Invoked);
            this.onTaskCreated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind29)));
            this.onTaskCreated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind28)));
            // 
            // logToHistoryListActivity122
            // 
            this.logToHistoryListActivity122.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity122.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity122.HistoryDescription = "Creating AGM Finance Review Task";
            this.logToHistoryListActivity122.HistoryOutcome = "";
            this.logToHistoryListActivity122.Name = "logToHistoryListActivity122";
            this.logToHistoryListActivity122.OtherData = "";
            this.logToHistoryListActivity122.UserId = -1;
            // 
            // ifElseActivity14
            // 
            this.ifElseActivity14.Activities.Add(this.adHocUser4TaskISOverdue);
            this.ifElseActivity14.Activities.Add(this.adHocUser4TaskIsNOTOverdue);
            this.ifElseActivity14.Name = "ifElseActivity14";
            // 
            // onAdHocUser4ReviewTaskCreated
            // 
            activitybind30.Name = "BoardAgendaWorkflow";
            activitybind30.Path = "onAdHocUser4ReviewTaskCreated_AfterProperties";
            correlationtoken13.Name = "adHocUser4ReviewTask";
            correlationtoken13.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser4ReviewTaskCreated.CorrelationToken = correlationtoken13;
            this.onAdHocUser4ReviewTaskCreated.Executor = null;
            this.onAdHocUser4ReviewTaskCreated.Name = "onAdHocUser4ReviewTaskCreated";
            activitybind31.Name = "BoardAgendaWorkflow";
            activitybind31.Path = "adHocUser4ReviewTask_TaskId";
            this.onAdHocUser4ReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser4ReviewTaskCreated_Invoked);
            this.onAdHocUser4ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind31)));
            this.onAdHocUser4ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind30)));
            // 
            // logToHistoryListActivity112
            // 
            this.logToHistoryListActivity112.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity112.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity112.HistoryDescription = "Creating AdhocUser4 Review Task(CAG)";
            this.logToHistoryListActivity112.HistoryOutcome = "";
            this.logToHistoryListActivity112.Name = "logToHistoryListActivity112";
            this.logToHistoryListActivity112.OtherData = "";
            this.logToHistoryListActivity112.UserId = -1;
            // 
            // logToHistoryListActivity108
            // 
            this.logToHistoryListActivity108.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity108.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity108.HistoryDescription = "AdHocUser3 Review Delay End";
            this.logToHistoryListActivity108.HistoryOutcome = "";
            this.logToHistoryListActivity108.Name = "logToHistoryListActivity108";
            this.logToHistoryListActivity108.OtherData = "";
            this.logToHistoryListActivity108.UserId = -1;
            // 
            // delayActivity12
            // 
            this.delayActivity12.Name = "delayActivity12";
            this.delayActivity12.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity107
            // 
            this.logToHistoryListActivity107.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity107.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity107.HistoryDescription = "AdHoc User 3 Review Delay Start";
            this.logToHistoryListActivity107.HistoryOutcome = "";
            this.logToHistoryListActivity107.Name = "logToHistoryListActivity107";
            this.logToHistoryListActivity107.OtherData = "";
            this.logToHistoryListActivity107.UserId = -1;
            // 
            // logToHistoryListActivity106
            // 
            this.logToHistoryListActivity106.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity106.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity106.HistoryDescription = "AdHoc User3 Review marked expired by system";
            this.logToHistoryListActivity106.HistoryOutcome = "";
            this.logToHistoryListActivity106.Name = "logToHistoryListActivity106";
            this.logToHistoryListActivity106.OtherData = "";
            this.logToHistoryListActivity106.UserId = -1;
            // 
            // onAdHocUser3ReviewTaskUpdated
            // 
            activitybind32.Name = "BoardAgendaWorkflow";
            activitybind32.Path = "onAdHocUser3ReviewTaskUpdated_AfterProperties";
            activitybind33.Name = "BoardAgendaWorkflow";
            activitybind33.Path = "onAdHocUser3ReviewTaskUpdated_BeforeProperties";
            correlationtoken14.Name = "adHocUser3ReviewTask";
            correlationtoken14.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser3ReviewTaskUpdated.CorrelationToken = correlationtoken14;
            this.onAdHocUser3ReviewTaskUpdated.Executor = null;
            this.onAdHocUser3ReviewTaskUpdated.Name = "onAdHocUser3ReviewTaskUpdated";
            activitybind34.Name = "BoardAgendaWorkflow";
            activitybind34.Path = "adHocUser3ReviewTask_TaskId";
            this.onAdHocUser3ReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdHocUser3ReviewTaskUpdated_Invoked);
            this.onAdHocUser3ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind33)));
            this.onAdHocUser3ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind34)));
            this.onAdHocUser3ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind32)));
            // 
            // adHocUser3TaskUpdated
            // 
            correlationtoken15.Name = "adHocUser3ReviewTask";
            correlationtoken15.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser3TaskUpdated.CorrelationToken = correlationtoken15;
            this.adHocUser3TaskUpdated.Name = "adHocUser3TaskUpdated";
            activitybind35.Name = "BoardAgendaWorkflow";
            activitybind35.Path = "adHocUser3ReviewTask_TaskId";
            activitybind36.Name = "BoardAgendaWorkflow";
            activitybind36.Path = "adHocUser3TaskUpdated_TaskProperties";
            this.adHocUser3TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind36)));
            this.adHocUser3TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind35)));
            // 
            // codeAdHocUser3reviewTaskExpired
            // 
            this.codeAdHocUser3reviewTaskExpired.Name = "codeAdHocUser3reviewTaskExpired";
            this.codeAdHocUser3reviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAdHocUser3reviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity105
            // 
            this.logToHistoryListActivity105.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity105.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity105.HistoryDescription = "AdHoc User3 Task is Overdue";
            this.logToHistoryListActivity105.HistoryOutcome = "";
            this.logToHistoryListActivity105.Name = "logToHistoryListActivity105";
            this.logToHistoryListActivity105.OtherData = "";
            this.logToHistoryListActivity105.UserId = -1;
            // 
            // logToHistoryListActivity99
            // 
            this.logToHistoryListActivity99.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity99.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity99.HistoryDescription = "AdHocUser2 Review Delay End";
            this.logToHistoryListActivity99.HistoryOutcome = "";
            this.logToHistoryListActivity99.Name = "logToHistoryListActivity99";
            this.logToHistoryListActivity99.OtherData = "";
            this.logToHistoryListActivity99.UserId = -1;
            // 
            // delayActivity11
            // 
            this.delayActivity11.Name = "delayActivity11";
            this.delayActivity11.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity98
            // 
            this.logToHistoryListActivity98.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity98.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity98.HistoryDescription = "AdHoc User 2 Review Delay Start";
            this.logToHistoryListActivity98.HistoryOutcome = "";
            this.logToHistoryListActivity98.Name = "logToHistoryListActivity98";
            this.logToHistoryListActivity98.OtherData = "";
            this.logToHistoryListActivity98.UserId = -1;
            // 
            // logToHistoryListActivity97
            // 
            this.logToHistoryListActivity97.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity97.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity97.HistoryDescription = "AdHoc User2 Review marked expired by system";
            this.logToHistoryListActivity97.HistoryOutcome = "";
            this.logToHistoryListActivity97.Name = "logToHistoryListActivity97";
            this.logToHistoryListActivity97.OtherData = "";
            this.logToHistoryListActivity97.UserId = -1;
            // 
            // onAdHocUser2ReviewTaskUpdated
            // 
            activitybind37.Name = "BoardAgendaWorkflow";
            activitybind37.Path = "onAdHocUser2ReviewTaskUpdated_AfterProperties";
            activitybind38.Name = "BoardAgendaWorkflow";
            activitybind38.Path = "onAdHocUser2ReviewTaskUpdated_BeforeProperties";
            correlationtoken16.Name = "adHocUser2ReviewTask";
            correlationtoken16.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser2ReviewTaskUpdated.CorrelationToken = correlationtoken16;
            this.onAdHocUser2ReviewTaskUpdated.Executor = null;
            this.onAdHocUser2ReviewTaskUpdated.Name = "onAdHocUser2ReviewTaskUpdated";
            activitybind39.Name = "BoardAgendaWorkflow";
            activitybind39.Path = "adHocUser2ReviewTask_TaskId";
            this.onAdHocUser2ReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdHocUser2ReviewTaskUpdated_Invoked);
            this.onAdHocUser2ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind38)));
            this.onAdHocUser2ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind39)));
            this.onAdHocUser2ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind37)));
            // 
            // adHocUser2TaskUpdated
            // 
            correlationtoken17.Name = "adHocUser2ReviewTask";
            correlationtoken17.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser2TaskUpdated.CorrelationToken = correlationtoken17;
            this.adHocUser2TaskUpdated.Name = "adHocUser2TaskUpdated";
            activitybind40.Name = "BoardAgendaWorkflow";
            activitybind40.Path = "adHocUser2ReviewTask_TaskId";
            activitybind41.Name = "BoardAgendaWorkflow";
            activitybind41.Path = "adHocUser2ReviewTask_TaskProperties";
            this.adHocUser2TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind41)));
            this.adHocUser2TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind40)));
            // 
            // codeAdHocUser2reviewTaskExpired
            // 
            this.codeAdHocUser2reviewTaskExpired.Name = "codeAdHocUser2reviewTaskExpired";
            this.codeAdHocUser2reviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAdHocUser2reviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity96
            // 
            this.logToHistoryListActivity96.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity96.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity96.HistoryDescription = "AdHoc User2 Task is Overdue";
            this.logToHistoryListActivity96.HistoryOutcome = "";
            this.logToHistoryListActivity96.Name = "logToHistoryListActivity96";
            this.logToHistoryListActivity96.OtherData = "";
            this.logToHistoryListActivity96.UserId = -1;
            // 
            // logToHistoryListActivity90
            // 
            this.logToHistoryListActivity90.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity90.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity90.HistoryDescription = "AdHocReview Delay End";
            this.logToHistoryListActivity90.HistoryOutcome = "";
            this.logToHistoryListActivity90.Name = "logToHistoryListActivity90";
            this.logToHistoryListActivity90.OtherData = "";
            this.logToHistoryListActivity90.UserId = -1;
            // 
            // delayActivity10
            // 
            this.delayActivity10.Name = "delayActivity10";
            this.delayActivity10.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity89
            // 
            this.logToHistoryListActivity89.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity89.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity89.HistoryDescription = "AdHocReview Delay Start";
            this.logToHistoryListActivity89.HistoryOutcome = "";
            this.logToHistoryListActivity89.Name = "logToHistoryListActivity89";
            this.logToHistoryListActivity89.OtherData = "";
            this.logToHistoryListActivity89.UserId = -1;
            // 
            // logToHistoryListActivity88
            // 
            this.logToHistoryListActivity88.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity88.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity88.HistoryDescription = "AdHoc User1 Review marked expired by system";
            this.logToHistoryListActivity88.HistoryOutcome = "";
            this.logToHistoryListActivity88.Name = "logToHistoryListActivity88";
            this.logToHistoryListActivity88.OtherData = "";
            this.logToHistoryListActivity88.UserId = -1;
            // 
            // onAdHocUser1ReviewTaskUpdated
            // 
            activitybind42.Name = "BoardAgendaWorkflow";
            activitybind42.Path = "onAdHocUser1ReviewTaskUpdated_AfterProperties";
            activitybind43.Name = "BoardAgendaWorkflow";
            activitybind43.Path = "onAdHocUser1ReviewTaskUpdated_BeforeProperties";
            correlationtoken18.Name = "adHocUser1ReviewTask";
            correlationtoken18.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser1ReviewTaskUpdated.CorrelationToken = correlationtoken18;
            this.onAdHocUser1ReviewTaskUpdated.Executor = null;
            this.onAdHocUser1ReviewTaskUpdated.Name = "onAdHocUser1ReviewTaskUpdated";
            activitybind44.Name = "BoardAgendaWorkflow";
            activitybind44.Path = "adHocUser1ReviewTask_TaskId";
            this.onAdHocUser1ReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdHocUser1ReviewTaskUpdated_Invoked);
            this.onAdHocUser1ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind43)));
            this.onAdHocUser1ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind44)));
            this.onAdHocUser1ReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind42)));
            // 
            // adHocUser1TaskUpdated
            // 
            correlationtoken19.Name = "adHocUser1ReviewTask";
            correlationtoken19.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser1TaskUpdated.CorrelationToken = correlationtoken19;
            this.adHocUser1TaskUpdated.Name = "adHocUser1TaskUpdated";
            activitybind45.Name = "BoardAgendaWorkflow";
            activitybind45.Path = "adHocUser1ReviewTask_TaskId";
            activitybind46.Name = "BoardAgendaWorkflow";
            activitybind46.Path = "adHocUser1TaskUpdated_TaskProperties";
            this.adHocUser1TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind46)));
            this.adHocUser1TaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind45)));
            // 
            // codeAdHocUser1reviewTaskExpired
            // 
            this.codeAdHocUser1reviewTaskExpired.Name = "codeAdHocUser1reviewTaskExpired";
            this.codeAdHocUser1reviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAdHocUser1reviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity87
            // 
            this.logToHistoryListActivity87.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity87.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity87.HistoryDescription = "AdHoc User1 Task is Overdue";
            this.logToHistoryListActivity87.HistoryOutcome = "";
            this.logToHistoryListActivity87.Name = "logToHistoryListActivity87";
            this.logToHistoryListActivity87.OtherData = "";
            this.logToHistoryListActivity87.UserId = -1;
            // 
            // logToHistoryListActivity81
            // 
            this.logToHistoryListActivity81.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity81.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity81.HistoryDescription = "AGMPoliceReview Delay End";
            this.logToHistoryListActivity81.HistoryOutcome = "";
            this.logToHistoryListActivity81.Name = "logToHistoryListActivity81";
            this.logToHistoryListActivity81.OtherData = "";
            this.logToHistoryListActivity81.UserId = -1;
            // 
            // delayActivity9
            // 
            this.delayActivity9.Name = "delayActivity9";
            this.delayActivity9.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity80
            // 
            this.logToHistoryListActivity80.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity80.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity80.HistoryDescription = "AGMPoliceReview Delay Start";
            this.logToHistoryListActivity80.HistoryOutcome = "";
            this.logToHistoryListActivity80.Name = "logToHistoryListActivity80";
            this.logToHistoryListActivity80.OtherData = "";
            this.logToHistoryListActivity80.UserId = -1;
            // 
            // logToHistoryListActivity79
            // 
            this.logToHistoryListActivity79.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity79.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity79.HistoryDescription = "AGM Police Review marked expired by system";
            this.logToHistoryListActivity79.HistoryOutcome = "";
            this.logToHistoryListActivity79.Name = "logToHistoryListActivity79";
            this.logToHistoryListActivity79.OtherData = "";
            this.logToHistoryListActivity79.UserId = -1;
            // 
            // onAGMPoliceReviewTaskUpdated
            // 
            activitybind47.Name = "BoardAgendaWorkflow";
            activitybind47.Path = "onAGMPoliceReviewTaskUpdated_AfterProperties";
            activitybind48.Name = "BoardAgendaWorkflow";
            activitybind48.Path = "onAGMPoliceReviewTaskUpdated_BeforeProperties";
            correlationtoken20.Name = "agmPoliceReviewTask";
            correlationtoken20.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMPoliceReviewTaskUpdated.CorrelationToken = correlationtoken20;
            this.onAGMPoliceReviewTaskUpdated.Executor = null;
            this.onAGMPoliceReviewTaskUpdated.Name = "onAGMPoliceReviewTaskUpdated";
            activitybind49.Name = "BoardAgendaWorkflow";
            activitybind49.Path = "agmPoliceReviewTask_TaskId";
            this.onAGMPoliceReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPoliceReviewTaskUpdated_Invoked);
            this.onAGMPoliceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind48)));
            this.onAGMPoliceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind49)));
            this.onAGMPoliceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind47)));
            // 
            // agmPoliceReviewTaskUpdated
            // 
            correlationtoken21.Name = "agmPoliceReviewTask";
            correlationtoken21.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPoliceReviewTaskUpdated.CorrelationToken = correlationtoken21;
            this.agmPoliceReviewTaskUpdated.Name = "agmPoliceReviewTaskUpdated";
            activitybind50.Name = "BoardAgendaWorkflow";
            activitybind50.Path = "agmPoliceReviewTask_TaskId";
            activitybind51.Name = "BoardAgendaWorkflow";
            activitybind51.Path = "agmPoliceReviewTaskUpdated_TaskProperties";
            this.agmPoliceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind51)));
            this.agmPoliceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind50)));
            // 
            // codeAGMPoliceReviewExpired
            // 
            this.codeAGMPoliceReviewExpired.Name = "codeAGMPoliceReviewExpired";
            this.codeAGMPoliceReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMPoliceReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity78
            // 
            this.logToHistoryListActivity78.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity78.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity78.HistoryDescription = "AGM Police Review Task has expired";
            this.logToHistoryListActivity78.HistoryOutcome = "";
            this.logToHistoryListActivity78.Name = "logToHistoryListActivity78";
            this.logToHistoryListActivity78.OtherData = "";
            this.logToHistoryListActivity78.UserId = -1;
            // 
            // logToHistoryListActivity72
            // 
            this.logToHistoryListActivity72.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity72.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity72.HistoryDescription = "AGMCommunicationsReview Delay End";
            this.logToHistoryListActivity72.HistoryOutcome = "";
            this.logToHistoryListActivity72.Name = "logToHistoryListActivity72";
            this.logToHistoryListActivity72.OtherData = "";
            this.logToHistoryListActivity72.UserId = -1;
            // 
            // delayActivity8
            // 
            this.delayActivity8.Name = "delayActivity8";
            this.delayActivity8.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity71
            // 
            this.logToHistoryListActivity71.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity71.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity71.HistoryDescription = "AGMCommunicationsReview Delay Start";
            this.logToHistoryListActivity71.HistoryOutcome = "";
            this.logToHistoryListActivity71.Name = "logToHistoryListActivity71";
            this.logToHistoryListActivity71.OtherData = "";
            this.logToHistoryListActivity71.UserId = -1;
            // 
            // logToHistoryListActivity70
            // 
            this.logToHistoryListActivity70.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity70.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity70.HistoryDescription = "AGM Communications Review marked expired by system";
            this.logToHistoryListActivity70.HistoryOutcome = "";
            this.logToHistoryListActivity70.Name = "logToHistoryListActivity70";
            this.logToHistoryListActivity70.OtherData = "";
            this.logToHistoryListActivity70.UserId = -1;
            // 
            // onAGMCommunicationsReviewTaskUpdated
            // 
            activitybind52.Name = "BoardAgendaWorkflow";
            activitybind52.Path = "onAGMCommunicationsReviewTaskUpdated_AfterProperties";
            activitybind53.Name = "BoardAgendaWorkflow";
            activitybind53.Path = "onAGMCommunicationsReviewTaskUpdated_BeforeProperties";
            correlationtoken22.Name = "agmCommunicationsReviewTask";
            correlationtoken22.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMCommunicationsReviewTaskUpdated.CorrelationToken = correlationtoken22;
            this.onAGMCommunicationsReviewTaskUpdated.Executor = null;
            this.onAGMCommunicationsReviewTaskUpdated.Name = "onAGMCommunicationsReviewTaskUpdated";
            activitybind54.Name = "BoardAgendaWorkflow";
            activitybind54.Path = "agmCommunicationsReviewTask_TaskId";
            this.onAGMCommunicationsReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMCommunicationsReviewTaskUpdated_Invoked);
            this.onAGMCommunicationsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind53)));
            this.onAGMCommunicationsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind54)));
            this.onAGMCommunicationsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind52)));
            // 
            // agmCommunicationsReviewTaskUpdated
            // 
            correlationtoken23.Name = "agmCommunicationsReviewTask";
            correlationtoken23.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmCommunicationsReviewTaskUpdated.CorrelationToken = correlationtoken23;
            this.agmCommunicationsReviewTaskUpdated.Name = "agmCommunicationsReviewTaskUpdated";
            activitybind55.Name = "BoardAgendaWorkflow";
            activitybind55.Path = "agmCommunicationsReviewTask_TaskId";
            activitybind56.Name = "BoardAgendaWorkflow";
            activitybind56.Path = "agmCommunicationsReviewTaskUpdated_TaskProperties";
            this.agmCommunicationsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind56)));
            this.agmCommunicationsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind55)));
            // 
            // codeAGMCommunicationsReviewExpired
            // 
            this.codeAGMCommunicationsReviewExpired.Name = "codeAGMCommunicationsReviewExpired";
            this.codeAGMCommunicationsReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMCommunicationsReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity69
            // 
            this.logToHistoryListActivity69.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity69.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity69.HistoryDescription = "AGM Finance Review Task has expired";
            this.logToHistoryListActivity69.HistoryOutcome = "";
            this.logToHistoryListActivity69.Name = "logToHistoryListActivity69";
            this.logToHistoryListActivity69.OtherData = "";
            this.logToHistoryListActivity69.UserId = -1;
            // 
            // logToHistoryListActivity63
            // 
            this.logToHistoryListActivity63.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity63.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity63.HistoryDescription = "AGMAuditReview Delay End";
            this.logToHistoryListActivity63.HistoryOutcome = "";
            this.logToHistoryListActivity63.Name = "logToHistoryListActivity63";
            this.logToHistoryListActivity63.OtherData = "";
            this.logToHistoryListActivity63.UserId = -1;
            // 
            // delayActivity7
            // 
            this.delayActivity7.Name = "delayActivity7";
            this.delayActivity7.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity62
            // 
            this.logToHistoryListActivity62.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity62.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity62.HistoryDescription = "AGMAuditReview Delay Start";
            this.logToHistoryListActivity62.HistoryOutcome = "";
            this.logToHistoryListActivity62.Name = "logToHistoryListActivity62";
            this.logToHistoryListActivity62.OtherData = "";
            this.logToHistoryListActivity62.UserId = -1;
            // 
            // logToHistoryListActivity61
            // 
            this.logToHistoryListActivity61.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity61.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity61.HistoryDescription = "AGM Contracts Review marked expired by system";
            this.logToHistoryListActivity61.HistoryOutcome = "";
            this.logToHistoryListActivity61.Name = "logToHistoryListActivity61";
            this.logToHistoryListActivity61.OtherData = "";
            this.logToHistoryListActivity61.UserId = -1;
            // 
            // onAGMAuditReviewTaskUpdated
            // 
            activitybind57.Name = "BoardAgendaWorkflow";
            activitybind57.Path = "onAGMAuditReviewTaskUpdated_AfterProperties";
            activitybind58.Name = "BoardAgendaWorkflow";
            activitybind58.Path = "onAGMAuditReviewTaskUpdated_BeforeProperties";
            correlationtoken24.Name = "agmAuditReviewTask";
            correlationtoken24.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMAuditReviewTaskUpdated.CorrelationToken = correlationtoken24;
            this.onAGMAuditReviewTaskUpdated.Executor = null;
            this.onAGMAuditReviewTaskUpdated.Name = "onAGMAuditReviewTaskUpdated";
            activitybind59.Name = "BoardAgendaWorkflow";
            activitybind59.Path = "agmAuditReviewTask_TaskId";
            this.onAGMAuditReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMAuditReviewTaskUpdated_Invoked);
            this.onAGMAuditReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind58)));
            this.onAGMAuditReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind59)));
            this.onAGMAuditReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind57)));
            // 
            // agmAuditReviewTaskUpdate
            // 
            correlationtoken25.Name = "agmAuditReviewTask";
            correlationtoken25.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmAuditReviewTaskUpdate.CorrelationToken = correlationtoken25;
            this.agmAuditReviewTaskUpdate.Name = "agmAuditReviewTaskUpdate";
            activitybind60.Name = "BoardAgendaWorkflow";
            activitybind60.Path = "agmAuditReviewTask_TaskId";
            activitybind61.Name = "BoardAgendaWorkflow";
            activitybind61.Path = "agmAuditReviewTaskUpdate_TaskProperties";
            this.agmAuditReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind61)));
            this.agmAuditReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind60)));
            // 
            // codeAGMAuditReviewExpired
            // 
            this.codeAGMAuditReviewExpired.Name = "codeAGMAuditReviewExpired";
            this.codeAGMAuditReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMAuditReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity60
            // 
            this.logToHistoryListActivity60.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity60.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity60.HistoryDescription = "AGM Audit Review Task has expired";
            this.logToHistoryListActivity60.HistoryOutcome = "";
            this.logToHistoryListActivity60.Name = "logToHistoryListActivity60";
            this.logToHistoryListActivity60.OtherData = "";
            this.logToHistoryListActivity60.UserId = -1;
            // 
            // logToHistoryListActivity54
            // 
            this.logToHistoryListActivity54.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity54.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity54.HistoryDescription = "AGMContractsReview Delay End";
            this.logToHistoryListActivity54.HistoryOutcome = "";
            this.logToHistoryListActivity54.Name = "logToHistoryListActivity54";
            this.logToHistoryListActivity54.OtherData = "";
            this.logToHistoryListActivity54.UserId = -1;
            // 
            // delayActivity6
            // 
            this.delayActivity6.Name = "delayActivity6";
            this.delayActivity6.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity53
            // 
            this.logToHistoryListActivity53.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity53.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity53.HistoryDescription = "AGMContractsReview Delay Start";
            this.logToHistoryListActivity53.HistoryOutcome = "";
            this.logToHistoryListActivity53.Name = "logToHistoryListActivity53";
            this.logToHistoryListActivity53.OtherData = "";
            this.logToHistoryListActivity53.UserId = -1;
            // 
            // logToHistoryListActivity52
            // 
            this.logToHistoryListActivity52.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity52.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity52.HistoryDescription = "AGM Contracts Review marked expired by system";
            this.logToHistoryListActivity52.HistoryOutcome = "";
            this.logToHistoryListActivity52.Name = "logToHistoryListActivity52";
            this.logToHistoryListActivity52.OtherData = "";
            this.logToHistoryListActivity52.UserId = -1;
            // 
            // onAGMContractsReviewTaskUpdated
            // 
            activitybind62.Name = "BoardAgendaWorkflow";
            activitybind62.Path = "onAGMContractsReviewTaskUpdated_AfterProperties";
            activitybind63.Name = "BoardAgendaWorkflow";
            activitybind63.Path = "onAGMContractsReviewTaskUpdated_BeforeProperties";
            correlationtoken26.Name = "agmContractsReviewTask";
            correlationtoken26.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMContractsReviewTaskUpdated.CorrelationToken = correlationtoken26;
            this.onAGMContractsReviewTaskUpdated.Executor = null;
            this.onAGMContractsReviewTaskUpdated.Name = "onAGMContractsReviewTaskUpdated";
            activitybind64.Name = "BoardAgendaWorkflow";
            activitybind64.Path = "agmContractsReviewTask_TaskId";
            this.onAGMContractsReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMContractsReviewTaskUpdated_Invoked);
            this.onAGMContractsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind63)));
            this.onAGMContractsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind64)));
            this.onAGMContractsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind62)));
            // 
            // agmContractsReviewTaskUpdated
            // 
            correlationtoken27.Name = "agmContractsReviewTask";
            correlationtoken27.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmContractsReviewTaskUpdated.CorrelationToken = correlationtoken27;
            this.agmContractsReviewTaskUpdated.Name = "agmContractsReviewTaskUpdated";
            activitybind65.Name = "BoardAgendaWorkflow";
            activitybind65.Path = "agmContractsReviewTask_TaskId";
            activitybind66.Name = "BoardAgendaWorkflow";
            activitybind66.Path = "agmContractsReviewTaskUpdated_TaskProperties";
            this.agmContractsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind66)));
            this.agmContractsReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind65)));
            // 
            // codeAGMContractsReviewExpired
            // 
            this.codeAGMContractsReviewExpired.Name = "codeAGMContractsReviewExpired";
            this.codeAGMContractsReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMContractsReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity51
            // 
            this.logToHistoryListActivity51.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity51.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity51.HistoryDescription = "AGM Contracts Review Task has expired";
            this.logToHistoryListActivity51.HistoryOutcome = "";
            this.logToHistoryListActivity51.Name = "logToHistoryListActivity51";
            this.logToHistoryListActivity51.OtherData = "";
            this.logToHistoryListActivity51.UserId = -1;
            // 
            // logToHistoryListActivity45
            // 
            this.logToHistoryListActivity45.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity45.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity45.HistoryDescription = "AGMFinanceReview Delay End";
            this.logToHistoryListActivity45.HistoryOutcome = "";
            this.logToHistoryListActivity45.Name = "logToHistoryListActivity45";
            this.logToHistoryListActivity45.OtherData = "";
            this.logToHistoryListActivity45.UserId = -1;
            // 
            // delayActivity5
            // 
            this.delayActivity5.Name = "delayActivity5";
            this.delayActivity5.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity44
            // 
            this.logToHistoryListActivity44.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity44.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity44.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logToHistoryListActivity44.HistoryOutcome = "";
            this.logToHistoryListActivity44.Name = "logToHistoryListActivity44";
            this.logToHistoryListActivity44.OtherData = "";
            this.logToHistoryListActivity44.UserId = -1;
            // 
            // logToHistoryListActivity43
            // 
            this.logToHistoryListActivity43.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity43.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity43.HistoryDescription = "AGM Legal Review marked expired by system";
            this.logToHistoryListActivity43.HistoryOutcome = "";
            this.logToHistoryListActivity43.Name = "logToHistoryListActivity43";
            this.logToHistoryListActivity43.OtherData = "";
            this.logToHistoryListActivity43.UserId = -1;
            // 
            // onAGMLegalReviewTaskUpdated
            // 
            activitybind67.Name = "BoardAgendaWorkflow";
            activitybind67.Path = "onAGMLegalReviewTaskUpdated_AfterProperties";
            activitybind68.Name = "BoardAgendaWorkflow";
            activitybind68.Path = "onAGMLegalReviewTaskUpdated_BeforeProperties";
            correlationtoken28.Name = "agmLegalReviewTask";
            correlationtoken28.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMLegalReviewTaskUpdated.CorrelationToken = correlationtoken28;
            this.onAGMLegalReviewTaskUpdated.Executor = null;
            this.onAGMLegalReviewTaskUpdated.Name = "onAGMLegalReviewTaskUpdated";
            activitybind69.Name = "BoardAgendaWorkflow";
            activitybind69.Path = "agmLegalReviewTask_TaskId";
            this.onAGMLegalReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMLegalReviewTaskUpdated_Invoked);
            this.onAGMLegalReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind68)));
            this.onAGMLegalReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind69)));
            this.onAGMLegalReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind67)));
            // 
            // agmLegalReviewTaskUpdate
            // 
            correlationtoken29.Name = "agmLegalReviewTask";
            correlationtoken29.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmLegalReviewTaskUpdate.CorrelationToken = correlationtoken29;
            this.agmLegalReviewTaskUpdate.Name = "agmLegalReviewTaskUpdate";
            activitybind70.Name = "BoardAgendaWorkflow";
            activitybind70.Path = "agmLegalReviewTask_TaskId";
            activitybind71.Name = "BoardAgendaWorkflow";
            activitybind71.Path = "agmLegalReviewTask_TaskProperties";
            this.agmLegalReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind71)));
            this.agmLegalReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind70)));
            // 
            // codeAGMLegalReviewExpired
            // 
            this.codeAGMLegalReviewExpired.Name = "codeAGMLegalReviewExpired";
            this.codeAGMLegalReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMLegalReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity42
            // 
            this.logToHistoryListActivity42.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity42.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity42.HistoryDescription = "AGM Legal Review Task has expired";
            this.logToHistoryListActivity42.HistoryOutcome = "";
            this.logToHistoryListActivity42.Name = "logToHistoryListActivity42";
            this.logToHistoryListActivity42.OtherData = "";
            this.logToHistoryListActivity42.UserId = -1;
            // 
            // logToHistoryListActivity36
            // 
            this.logToHistoryListActivity36.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity36.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity36.HistoryDescription = "AGMFinanceReview Delay End";
            this.logToHistoryListActivity36.HistoryOutcome = "";
            this.logToHistoryListActivity36.Name = "logToHistoryListActivity36";
            this.logToHistoryListActivity36.OtherData = "";
            this.logToHistoryListActivity36.UserId = -1;
            // 
            // delayActivity4
            // 
            this.delayActivity4.Name = "delayActivity4";
            this.delayActivity4.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity35
            // 
            this.logToHistoryListActivity35.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity35.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity35.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logToHistoryListActivity35.HistoryOutcome = "";
            this.logToHistoryListActivity35.Name = "logToHistoryListActivity35";
            this.logToHistoryListActivity35.OtherData = "";
            this.logToHistoryListActivity35.UserId = -1;
            // 
            // logToHistoryListActivity34
            // 
            this.logToHistoryListActivity34.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity34.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity34.HistoryDescription = "AGM Safety Review marked expired by system";
            this.logToHistoryListActivity34.HistoryOutcome = "";
            this.logToHistoryListActivity34.Name = "logToHistoryListActivity34";
            this.logToHistoryListActivity34.OtherData = "";
            this.logToHistoryListActivity34.UserId = -1;
            // 
            // onAGMSafetyReviewTaskUpdated
            // 
            activitybind72.Name = "BoardAgendaWorkflow";
            activitybind72.Path = "onAGMSafetyReviewTaskUpdated_AfterProperties";
            activitybind73.Name = "BoardAgendaWorkflow";
            activitybind73.Path = "onAGMSafetyReviewTaskUpdated_BeforeProperties";
            correlationtoken30.Name = "agmSafetyReviewTask";
            correlationtoken30.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMSafetyReviewTaskUpdated.CorrelationToken = correlationtoken30;
            this.onAGMSafetyReviewTaskUpdated.Executor = null;
            this.onAGMSafetyReviewTaskUpdated.Name = "onAGMSafetyReviewTaskUpdated";
            activitybind74.Name = "BoardAgendaWorkflow";
            activitybind74.Path = "agmSafetyReviewTask_TaskId";
            this.onAGMSafetyReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMSafetyReviewTaskUpdated_Invoked);
            this.onAGMSafetyReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind73)));
            this.onAGMSafetyReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind74)));
            this.onAGMSafetyReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind72)));
            // 
            // agmSafetyReviewTaskUpdate
            // 
            correlationtoken31.Name = "agmSafetyReviewTask";
            correlationtoken31.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmSafetyReviewTaskUpdate.CorrelationToken = correlationtoken31;
            this.agmSafetyReviewTaskUpdate.Name = "agmSafetyReviewTaskUpdate";
            activitybind75.Name = "BoardAgendaWorkflow";
            activitybind75.Path = "agmSafetyReviewTask_TaskId";
            activitybind76.Name = "BoardAgendaWorkflow";
            activitybind76.Path = "agmSafetyReviewTaskUpdate_TaskProperties";
            this.agmSafetyReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind76)));
            this.agmSafetyReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind75)));
            // 
            // codeAGMSafetyReviewExpired
            // 
            this.codeAGMSafetyReviewExpired.Name = "codeAGMSafetyReviewExpired";
            this.codeAGMSafetyReviewExpired.ExecuteCode += new System.EventHandler(this.codeAGMSafetyReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity33
            // 
            this.logToHistoryListActivity33.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity33.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity33.HistoryDescription = "AGM Safety Review task has expired";
            this.logToHistoryListActivity33.HistoryOutcome = "";
            this.logToHistoryListActivity33.Name = "logToHistoryListActivity33";
            this.logToHistoryListActivity33.OtherData = "";
            this.logToHistoryListActivity33.UserId = -1;
            // 
            // logToHistoryListActivity27
            // 
            this.logToHistoryListActivity27.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity27.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity27.HistoryDescription = "AGMHumanResourcesReview Delay End";
            this.logToHistoryListActivity27.HistoryOutcome = "";
            this.logToHistoryListActivity27.Name = "logToHistoryListActivity27";
            this.logToHistoryListActivity27.OtherData = "";
            this.logToHistoryListActivity27.UserId = -1;
            // 
            // delayActivity3
            // 
            this.delayActivity3.Name = "delayActivity3";
            this.delayActivity3.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity26
            // 
            this.logToHistoryListActivity26.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity26.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity26.HistoryDescription = "AGMHumanResourcesReview Delay Start";
            this.logToHistoryListActivity26.HistoryOutcome = "";
            this.logToHistoryListActivity26.Name = "logToHistoryListActivity26";
            this.logToHistoryListActivity26.OtherData = "";
            this.logToHistoryListActivity26.UserId = -1;
            // 
            // logToHistoryListActivity25
            // 
            this.logToHistoryListActivity25.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity25.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity25.HistoryDescription = "AGM Human Resources Review marked expired by system";
            this.logToHistoryListActivity25.HistoryOutcome = "";
            this.logToHistoryListActivity25.Name = "logToHistoryListActivity25";
            this.logToHistoryListActivity25.OtherData = "";
            this.logToHistoryListActivity25.UserId = -1;
            // 
            // onAGMHumanResourcesTaskUpdated
            // 
            activitybind77.Name = "BoardAgendaWorkflow";
            activitybind77.Path = "onAGMHumanResourcesTaskUpdated_AfterProperties";
            activitybind78.Name = "BoardAgendaWorkflow";
            activitybind78.Path = "onAGMHumanResourcesTaskUpdated_BeforeProperties";
            correlationtoken32.Name = "agmHumanResourcesReviewTask";
            correlationtoken32.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMHumanResourcesTaskUpdated.CorrelationToken = correlationtoken32;
            this.onAGMHumanResourcesTaskUpdated.Executor = null;
            this.onAGMHumanResourcesTaskUpdated.Name = "onAGMHumanResourcesTaskUpdated";
            activitybind79.Name = "BoardAgendaWorkflow";
            activitybind79.Path = "agmHumanResourcesReviewTask_TaskId";
            this.onAGMHumanResourcesTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMHumanResourcesReviewTaskUpdated_Invoked);
            this.onAGMHumanResourcesTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind78)));
            this.onAGMHumanResourcesTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind79)));
            this.onAGMHumanResourcesTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind77)));
            // 
            // agmHumanResourcesTaskUpdate
            // 
            correlationtoken33.Name = "agmHumanResourcesReviewTask";
            correlationtoken33.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmHumanResourcesTaskUpdate.CorrelationToken = correlationtoken33;
            this.agmHumanResourcesTaskUpdate.Name = "agmHumanResourcesTaskUpdate";
            activitybind80.Name = "BoardAgendaWorkflow";
            activitybind80.Path = "agmHumanResourcesReviewTask_TaskId";
            activitybind81.Name = "BoardAgendaWorkflow";
            activitybind81.Path = "agmHumanResourcesTaskUpdate_TaskProperties";
            this.agmHumanResourcesTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind81)));
            this.agmHumanResourcesTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind80)));
            // 
            // codeAGMHumanResourcesTaskExpired
            // 
            this.codeAGMHumanResourcesTaskExpired.Name = "codeAGMHumanResourcesTaskExpired";
            this.codeAGMHumanResourcesTaskExpired.ExecuteCode += new System.EventHandler(this.codeAGMHumanResourcesReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity24
            // 
            this.logToHistoryListActivity24.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity24.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity24.HistoryDescription = "AGM HumanResources Review Task has expired";
            this.logToHistoryListActivity24.HistoryOutcome = "";
            this.logToHistoryListActivity24.Name = "logToHistoryListActivity24";
            this.logToHistoryListActivity24.OtherData = "";
            this.logToHistoryListActivity24.UserId = -1;
            // 
            // logToHistoryListActivity18
            // 
            this.logToHistoryListActivity18.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity18.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity18.HistoryDescription = "AGMPlanningReview Delay End";
            this.logToHistoryListActivity18.HistoryOutcome = "";
            this.logToHistoryListActivity18.Name = "logToHistoryListActivity18";
            this.logToHistoryListActivity18.OtherData = "";
            this.logToHistoryListActivity18.UserId = -1;
            // 
            // delayActivity2
            // 
            this.delayActivity2.Name = "delayActivity2";
            this.delayActivity2.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity17
            // 
            this.logToHistoryListActivity17.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity17.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity17.HistoryDescription = "AGMPlanningReview Delay Start";
            this.logToHistoryListActivity17.HistoryOutcome = "";
            this.logToHistoryListActivity17.Name = "logToHistoryListActivity17";
            this.logToHistoryListActivity17.OtherData = "";
            this.logToHistoryListActivity17.UserId = -1;
            // 
            // logToHistoryListActivity16
            // 
            this.logToHistoryListActivity16.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity16.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity16.HistoryDescription = "AGM Planning Review marked expired by system";
            this.logToHistoryListActivity16.HistoryOutcome = "";
            this.logToHistoryListActivity16.Name = "logToHistoryListActivity16";
            this.logToHistoryListActivity16.OtherData = "";
            this.logToHistoryListActivity16.UserId = -1;
            // 
            // onagmPlanningReviewTaskUpdated
            // 
            activitybind82.Name = "BoardAgendaWorkflow";
            activitybind82.Path = "onagmPlanningReviewTaskUpdated_AfterProperties";
            activitybind83.Name = "BoardAgendaWorkflow";
            activitybind83.Path = "onagmPlanningReviewTaskUpdated_BeforeProperties";
            correlationtoken34.Name = "agmPlanningReviewTask";
            correlationtoken34.OwnerActivityName = "BoardAgendaWorkflow";
            this.onagmPlanningReviewTaskUpdated.CorrelationToken = correlationtoken34;
            this.onagmPlanningReviewTaskUpdated.Executor = null;
            this.onagmPlanningReviewTaskUpdated.Name = "onagmPlanningReviewTaskUpdated";
            activitybind84.Name = "BoardAgendaWorkflow";
            activitybind84.Path = "agmPlanningReviewTask_TaskId";
            this.onagmPlanningReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPlanningReviewTaskUpdated_Invoked);
            this.onagmPlanningReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind83)));
            this.onagmPlanningReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind84)));
            this.onagmPlanningReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind82)));
            // 
            // agmPlanningReviewTaskUpdate
            // 
            correlationtoken35.Name = "agmPlanningReviewTask";
            correlationtoken35.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPlanningReviewTaskUpdate.CorrelationToken = correlationtoken35;
            this.agmPlanningReviewTaskUpdate.Name = "agmPlanningReviewTaskUpdate";
            activitybind85.Name = "BoardAgendaWorkflow";
            activitybind85.Path = "agmPlanningReviewTask_TaskId";
            activitybind86.Name = "BoardAgendaWorkflow";
            activitybind86.Path = "agmPlanningReviewTaskUpdate_TaskProperties";
            this.agmPlanningReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind86)));
            this.agmPlanningReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind85)));
            // 
            // codeAGMPlanningReviewTaskExpired
            // 
            this.codeAGMPlanningReviewTaskExpired.Name = "codeAGMPlanningReviewTaskExpired";
            this.codeAGMPlanningReviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAGMPlanningReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity15
            // 
            this.logToHistoryListActivity15.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity15.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity15.HistoryDescription = "AGM Planning Review Task has expired";
            this.logToHistoryListActivity15.HistoryOutcome = "";
            this.logToHistoryListActivity15.Name = "logToHistoryListActivity15";
            this.logToHistoryListActivity15.OtherData = "";
            this.logToHistoryListActivity15.UserId = -1;
            // 
            // logToHistoryListActivity9
            // 
            this.logToHistoryListActivity9.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity9.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity9.HistoryDescription = "AGMITReview Delay End";
            this.logToHistoryListActivity9.HistoryOutcome = "";
            this.logToHistoryListActivity9.Name = "logToHistoryListActivity9";
            this.logToHistoryListActivity9.OtherData = "";
            this.logToHistoryListActivity9.UserId = -1;
            // 
            // delayActivity1
            // 
            this.delayActivity1.Name = "delayActivity1";
            this.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            this.delayActivity1.InitializeTimeoutDuration += new System.EventHandler(this.delayActivity1_InitializeTimeoutDuration);
            // 
            // logToHistoryListActivity8
            // 
            this.logToHistoryListActivity8.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity8.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity8.HistoryDescription = "AGMITReview Delay Start";
            this.logToHistoryListActivity8.HistoryOutcome = "";
            this.logToHistoryListActivity8.Name = "logToHistoryListActivity8";
            this.logToHistoryListActivity8.OtherData = "";
            this.logToHistoryListActivity8.UserId = -1;
            // 
            // logToHistoryListActivity7
            // 
            this.logToHistoryListActivity7.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity7.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity7.HistoryDescription = "AGM IT Review marked expired by system";
            this.logToHistoryListActivity7.HistoryOutcome = "";
            this.logToHistoryListActivity7.Name = "logToHistoryListActivity7";
            this.logToHistoryListActivity7.OtherData = "";
            this.logToHistoryListActivity7.UserId = -1;
            // 
            // onAGMITReviewTaskUpdated
            // 
            activitybind87.Name = "BoardAgendaWorkflow";
            activitybind87.Path = "onAGMITReviewTaskUpdated_AfterProperties";
            activitybind88.Name = "BoardAgendaWorkflow";
            activitybind88.Path = "onAGMITReviewTaskUpdated_BeforeProperties";
            correlationtoken36.Name = "agmITReviewTask";
            correlationtoken36.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMITReviewTaskUpdated.CorrelationToken = correlationtoken36;
            this.onAGMITReviewTaskUpdated.Executor = null;
            this.onAGMITReviewTaskUpdated.Name = "onAGMITReviewTaskUpdated";
            activitybind89.Name = "BoardAgendaWorkflow";
            activitybind89.Path = "agmITReviewTask_TaskId";
            this.onAGMITReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMITReviewTaskUpdated_Invoked);
            this.onAGMITReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind88)));
            this.onAGMITReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind89)));
            this.onAGMITReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind87)));
            // 
            // agmITReviewTaskUpdate
            // 
            correlationtoken37.Name = "agmITReviewTask";
            correlationtoken37.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmITReviewTaskUpdate.CorrelationToken = correlationtoken37;
            this.agmITReviewTaskUpdate.Name = "agmITReviewTaskUpdate";
            activitybind90.Name = "BoardAgendaWorkflow";
            activitybind90.Path = "agmITReviewTask_TaskId";
            activitybind91.Name = "BoardAgendaWorkflow";
            activitybind91.Path = "agmITReviewTaskUpdate_TaskProperties";
            this.agmITReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind91)));
            this.agmITReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind90)));
            // 
            // codeAGMITReviewTaskExpired
            // 
            this.codeAGMITReviewTaskExpired.Name = "codeAGMITReviewTaskExpired";
            this.codeAGMITReviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAGMITReviewTaskExpired_ExecuteCode);
            // 
            // logToHistoryListActivity6
            // 
            this.logToHistoryListActivity6.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity6.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity6.HistoryDescription = "AGM IT Review Task has expired";
            this.logToHistoryListActivity6.HistoryOutcome = "";
            this.logToHistoryListActivity6.Name = "logToHistoryListActivity6";
            this.logToHistoryListActivity6.OtherData = "";
            this.logToHistoryListActivity6.UserId = -1;
            // 
            // logAGMFinanceReviewDelayEnd
            // 
            this.logAGMFinanceReviewDelayEnd.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewDelayEnd.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewDelayEnd.HistoryDescription = "AGMFinanceReview Delay End";
            this.logAGMFinanceReviewDelayEnd.HistoryOutcome = "";
            this.logAGMFinanceReviewDelayEnd.Name = "logAGMFinanceReviewDelayEnd";
            this.logAGMFinanceReviewDelayEnd.OtherData = "";
            this.logAGMFinanceReviewDelayEnd.UserId = -1;
            // 
            // delayActivityForAGMFinanceReviewTask
            // 
            this.delayActivityForAGMFinanceReviewTask.Name = "delayActivityForAGMFinanceReviewTask";
            this.delayActivityForAGMFinanceReviewTask.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logAGMFinanceReviewDelayStart
            // 
            this.logAGMFinanceReviewDelayStart.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewDelayStart.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewDelayStart.HistoryDescription = "AGMFinanceReview Delay Start";
            this.logAGMFinanceReviewDelayStart.HistoryOutcome = "";
            this.logAGMFinanceReviewDelayStart.Name = "logAGMFinanceReviewDelayStart";
            this.logAGMFinanceReviewDelayStart.OtherData = "";
            this.logAGMFinanceReviewDelayStart.UserId = -1;
            // 
            // logAGMFinanceReviewTaskMarkedExpired
            // 
            this.logAGMFinanceReviewTaskMarkedExpired.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewTaskMarkedExpired.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewTaskMarkedExpired.HistoryDescription = "AGM Finance Review marked expired by system";
            this.logAGMFinanceReviewTaskMarkedExpired.HistoryOutcome = "";
            this.logAGMFinanceReviewTaskMarkedExpired.Name = "logAGMFinanceReviewTaskMarkedExpired";
            this.logAGMFinanceReviewTaskMarkedExpired.OtherData = "";
            this.logAGMFinanceReviewTaskMarkedExpired.UserId = -1;
            // 
            // onAGMFinanceReviewTaskUpdated
            // 
            activitybind92.Name = "BoardAgendaWorkflow";
            activitybind92.Path = "onAGMFinanceReviewTaskUpdated_AfterProperties";
            activitybind93.Name = "BoardAgendaWorkflow";
            activitybind93.Path = "onAGMFinanceReviewTaskUpdated_BeforeProperties";
            correlationtoken38.Name = "agmFinanceReviewTask";
            correlationtoken38.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMFinanceReviewTaskUpdated.CorrelationToken = correlationtoken38;
            this.onAGMFinanceReviewTaskUpdated.Executor = null;
            this.onAGMFinanceReviewTaskUpdated.Name = "onAGMFinanceReviewTaskUpdated";
            activitybind94.Name = "BoardAgendaWorkflow";
            activitybind94.Path = "agmFinanceReviewTask_TaskId";
            this.onAGMFinanceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind93)));
            this.onAGMFinanceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind94)));
            this.onAGMFinanceReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind92)));
            // 
            // agmFinanceReviewTaskUpdate
            // 
            correlationtoken39.Name = "agmFinanceReviewTask";
            correlationtoken39.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmFinanceReviewTaskUpdate.CorrelationToken = correlationtoken39;
            this.agmFinanceReviewTaskUpdate.Name = "agmFinanceReviewTaskUpdate";
            activitybind95.Name = "BoardAgendaWorkflow";
            activitybind95.Path = "agmFinanceReviewTask_TaskId";
            activitybind96.Name = "BoardAgendaWorkflow";
            activitybind96.Path = "agmFinanceReviewTaskUpdate_TaskProperties";
            this.agmFinanceReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind96)));
            this.agmFinanceReviewTaskUpdate.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind95)));
            // 
            // codeAGMFinanceReviewTaskExpired
            // 
            this.codeAGMFinanceReviewTaskExpired.Name = "codeAGMFinanceReviewTaskExpired";
            this.codeAGMFinanceReviewTaskExpired.ExecuteCode += new System.EventHandler(this.codeAGMFinanceReviewTaskExpired_ExecuteCode);
            // 
            // logAGMFinanceReviewTaskExpired
            // 
            this.logAGMFinanceReviewTaskExpired.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewTaskExpired.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewTaskExpired.HistoryDescription = "";
            this.logAGMFinanceReviewTaskExpired.HistoryOutcome = "";
            this.logAGMFinanceReviewTaskExpired.Name = "logAGMFinanceReviewTaskExpired";
            this.logAGMFinanceReviewTaskExpired.OtherData = "";
            this.logAGMFinanceReviewTaskExpired.UserId = -1;
            // 
            // logToHistoryListActivity154
            // 
            this.logToHistoryListActivity154.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity154.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity154.HistoryDescription = "Executive Director was NOT selected";
            this.logToHistoryListActivity154.HistoryOutcome = "";
            this.logToHistoryListActivity154.Name = "logToHistoryListActivity154";
            this.logToHistoryListActivity154.OtherData = "";
            this.logToHistoryListActivity154.UserId = -1;
            // 
            // conditionedActivityGroup5
            // 
            this.conditionedActivityGroup5.Activities.Add(this.sequenceActivity94);
            this.conditionedActivityGroup5.Activities.Add(this.sequenceActivity95);
            this.conditionedActivityGroup5.Activities.Add(this.sequenceActivity96);
            this.conditionedActivityGroup5.Enabled = false;
            this.conditionedActivityGroup5.Name = "conditionedActivityGroup5";
            ruleconditionreference2.ConditionName = "AGM Finance Review Task IS completed";
            this.conditionedActivityGroup5.UntilCondition = ruleconditionreference2;
            // 
            // logToHistoryListActivity153
            // 
            this.logToHistoryListActivity153.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity153.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity153.HistoryDescription = "Executive Director Review Task Completed";
            this.logToHistoryListActivity153.HistoryOutcome = "";
            this.logToHistoryListActivity153.Name = "logToHistoryListActivity153";
            this.logToHistoryListActivity153.OtherData = "";
            this.logToHistoryListActivity153.UserId = -1;
            // 
            // executiveDirectorReviewTaskCompleted
            // 
            this.executiveDirectorReviewTaskCompleted.CorrelationToken = correlationtoken10;
            this.executiveDirectorReviewTaskCompleted.Name = "executiveDirectorReviewTaskCompleted";
            activitybind97.Name = "BoardAgendaWorkflow";
            activitybind97.Path = "executiveDirectorReviewTask_TaskId";
            this.executiveDirectorReviewTaskCompleted.TaskOutcome = null;
            this.executiveDirectorReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind97)));
            // 
            // whileActivity1
            // 
            this.whileActivity1.Activities.Add(this.onExecutiveDirectorReviewTaskChanged);
            ruleconditionreference3.ConditionName = "Check if Executive Director task is complete";
            this.whileActivity1.Condition = ruleconditionreference3;
            this.whileActivity1.Name = "whileActivity1";
            // 
            // logToHistoryListActivity152
            // 
            this.logToHistoryListActivity152.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity152.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity152.HistoryDescription = "Executive Director Review task created";
            this.logToHistoryListActivity152.HistoryOutcome = "";
            this.logToHistoryListActivity152.Name = "logToHistoryListActivity152";
            this.logToHistoryListActivity152.OtherData = "";
            this.logToHistoryListActivity152.UserId = -1;
            // 
            // sendEmailExecutiveDirectorAdmin
            // 
            this.sendEmailExecutiveDirectorAdmin.BCC = null;
            this.sendEmailExecutiveDirectorAdmin.Body = null;
            this.sendEmailExecutiveDirectorAdmin.CC = null;
            correlationtoken40.Name = "workflowToken";
            correlationtoken40.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailExecutiveDirectorAdmin.CorrelationToken = correlationtoken40;
            this.sendEmailExecutiveDirectorAdmin.From = null;
            this.sendEmailExecutiveDirectorAdmin.Headers = null;
            this.sendEmailExecutiveDirectorAdmin.IncludeStatus = false;
            this.sendEmailExecutiveDirectorAdmin.Name = "sendEmailExecutiveDirectorAdmin";
            this.sendEmailExecutiveDirectorAdmin.Subject = null;
            this.sendEmailExecutiveDirectorAdmin.To = null;
            this.sendEmailExecutiveDirectorAdmin.MethodInvoking += new System.EventHandler(this.sendEmailExecutiveDirectorAdmin_MethodInvoking);
            // 
            // executiveDirectorReviewTask
            // 
            this.executiveDirectorReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.executiveDirectorReviewTask.CorrelationToken = correlationtoken10;
            this.executiveDirectorReviewTask.ListItemId = -1;
            this.executiveDirectorReviewTask.Name = "executiveDirectorReviewTask";
            this.executiveDirectorReviewTask.SpecialPermissions = null;
            activitybind98.Name = "BoardAgendaWorkflow";
            activitybind98.Path = "executiveDirectorReviewTask_TaskId";
            activitybind99.Name = "BoardAgendaWorkflow";
            activitybind99.Path = "executiveDirectorReviewTask_TaskProperties";
            this.executiveDirectorReviewTask.MethodInvoking += new System.EventHandler(this.executiveDirectorReviewTask_MethodInvoking);
            this.executiveDirectorReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind99)));
            this.executiveDirectorReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind98)));
            // 
            // logToHistoryListActivity151
            // 
            this.logToHistoryListActivity151.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity151.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity151.HistoryDescription = "Creating Executive Director Review Task";
            this.logToHistoryListActivity151.HistoryOutcome = "";
            this.logToHistoryListActivity151.Name = "logToHistoryListActivity151";
            this.logToHistoryListActivity151.OtherData = "";
            this.logToHistoryListActivity151.UserId = -1;
            ruleconditionreference4.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // sequenceActivity82
            // 
            this.sequenceActivity82.Activities.Add(this.ifElseActivity16);
            this.sequenceActivity82.Name = "sequenceActivity82";
            this.sequenceActivity82.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference4);
            // 
            // sequenceActivity81
            // 
            this.sequenceActivity81.Name = "sequenceActivity81";
            // 
            // sequenceActivity80
            // 
            this.sequenceActivity80.Activities.Add(this.logToHistoryListActivity131);
            this.sequenceActivity80.Activities.Add(this.onTaskCreated2);
            this.sequenceActivity80.Name = "sequenceActivity80";
            // 
            // onAGMRailOperationsReviewTaskChanged
            // 
            activitybind100.Name = "BoardAgendaWorkflow";
            activitybind100.Path = "onAGMRailOperationsReviewTaskChanged_AfterProperties";
            activitybind101.Name = "BoardAgendaWorkflow";
            activitybind101.Path = "onAGMRailOperationsReviewTaskChanged_BeforeProperties";
            correlationtoken41.Name = "agmRailOperationsReviewTask";
            correlationtoken41.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMRailOperationsReviewTaskChanged.CorrelationToken = correlationtoken41;
            this.onAGMRailOperationsReviewTaskChanged.Executor = null;
            this.onAGMRailOperationsReviewTaskChanged.Name = "onAGMRailOperationsReviewTaskChanged";
            activitybind102.Name = "BoardAgendaWorkflow";
            activitybind102.Path = "agmRailOperationsReviewTask_TaskId";
            this.onAGMRailOperationsReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMRailOperationsReviewTaskChanged_Invoked);
            this.onAGMRailOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind101)));
            this.onAGMRailOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind102)));
            this.onAGMRailOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind100)));
            ruleconditionreference5.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // sequenceActivity79
            // 
            this.sequenceActivity79.Activities.Add(this.ifElseActivity15);
            this.sequenceActivity79.Name = "sequenceActivity79";
            this.sequenceActivity79.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference5);
            // 
            // sequenceActivity78
            // 
            this.sequenceActivity78.Name = "sequenceActivity78";
            // 
            // sequenceActivity77
            // 
            this.sequenceActivity77.Activities.Add(this.logToHistoryListActivity122);
            this.sequenceActivity77.Activities.Add(this.onTaskCreated1);
            this.sequenceActivity77.Name = "sequenceActivity77";
            // 
            // onAGMBusOperationsReviewTaskChanged
            // 
            activitybind103.Name = "BoardAgendaWorkflow";
            activitybind103.Path = "onAGMBusOperationsReviewTaskChanged_AfterProperties";
            activitybind104.Name = "BoardAgendaWorkflow";
            activitybind104.Path = "onAGMBusOperationsReviewTaskChanged_BeforeProperties";
            correlationtoken42.Name = "agmBusOperationsReviewTask";
            correlationtoken42.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMBusOperationsReviewTaskChanged.CorrelationToken = correlationtoken42;
            this.onAGMBusOperationsReviewTaskChanged.Executor = null;
            this.onAGMBusOperationsReviewTaskChanged.Name = "onAGMBusOperationsReviewTaskChanged";
            activitybind105.Name = "BoardAgendaWorkflow";
            activitybind105.Path = "agmBusOperationsReviewTask_TaskId";
            this.onAGMBusOperationsReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMBusOperationsReviewTaskChanged_Invoked);
            this.onAGMBusOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind104)));
            this.onAGMBusOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind105)));
            this.onAGMBusOperationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind103)));
            ruleconditionreference6.ConditionName = "AdHoc User3 Task Created But not Completed";
            // 
            // sequenceActivity76
            // 
            this.sequenceActivity76.Activities.Add(this.ifElseActivity14);
            this.sequenceActivity76.Name = "sequenceActivity76";
            this.sequenceActivity76.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference6);
            // 
            // sequenceActivity75
            // 
            this.sequenceActivity75.Name = "sequenceActivity75";
            // 
            // sequenceActivity74
            // 
            this.sequenceActivity74.Activities.Add(this.logToHistoryListActivity112);
            this.sequenceActivity74.Activities.Add(this.onAdHocUser4ReviewTaskCreated);
            this.sequenceActivity74.Name = "sequenceActivity74";
            // 
            // onAdHocUser4TaskChanged
            // 
            activitybind106.Name = "BoardAgendaWorkflow";
            activitybind106.Path = "onAdHocUser4TaskChanged_AfterProperties";
            activitybind107.Name = "BoardAgendaWorkflow";
            activitybind107.Path = "onAdHocUser4TaskChanged_BeforeProperties";
            correlationtoken43.Name = "adHocUser4ReviewTask";
            correlationtoken43.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser4TaskChanged.CorrelationToken = correlationtoken43;
            this.onAdHocUser4TaskChanged.Executor = null;
            this.onAdHocUser4TaskChanged.Name = "onAdHocUser4TaskChanged";
            activitybind108.Name = "BoardAgendaWorkflow";
            activitybind108.Path = "adHocUser4ReviewTask_TaskId";
            this.onAdHocUser4TaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser4ReviewTaskChanged_Invoked);
            this.onAdHocUser4TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind107)));
            this.onAdHocUser4TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind108)));
            this.onAdHocUser4TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind106)));
            // 
            // adHocUser3TaskIsNOTOverdue
            // 
            this.adHocUser3TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity107);
            this.adHocUser3TaskIsNOTOverdue.Activities.Add(this.delayActivity12);
            this.adHocUser3TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity108);
            this.adHocUser3TaskIsNOTOverdue.Name = "adHocUser3TaskIsNOTOverdue";
            // 
            // adHocUser3TaskISOverdue
            // 
            this.adHocUser3TaskISOverdue.Activities.Add(this.logToHistoryListActivity105);
            this.adHocUser3TaskISOverdue.Activities.Add(this.codeAdHocUser3reviewTaskExpired);
            this.adHocUser3TaskISOverdue.Activities.Add(this.adHocUser3TaskUpdated);
            this.adHocUser3TaskISOverdue.Activities.Add(this.onAdHocUser3ReviewTaskUpdated);
            this.adHocUser3TaskISOverdue.Activities.Add(this.logToHistoryListActivity106);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAdHocUser3ReviewTaskOverDue);
            this.adHocUser3TaskISOverdue.Condition = codecondition5;
            this.adHocUser3TaskISOverdue.Name = "adHocUser3TaskISOverdue";
            // 
            // adHocUser2TaskIsNOTOverdue
            // 
            this.adHocUser2TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity98);
            this.adHocUser2TaskIsNOTOverdue.Activities.Add(this.delayActivity11);
            this.adHocUser2TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity99);
            this.adHocUser2TaskIsNOTOverdue.Name = "adHocUser2TaskIsNOTOverdue";
            // 
            // adHocUser2TaskISOverdue
            // 
            this.adHocUser2TaskISOverdue.Activities.Add(this.logToHistoryListActivity96);
            this.adHocUser2TaskISOverdue.Activities.Add(this.codeAdHocUser2reviewTaskExpired);
            this.adHocUser2TaskISOverdue.Activities.Add(this.adHocUser2TaskUpdated);
            this.adHocUser2TaskISOverdue.Activities.Add(this.onAdHocUser2ReviewTaskUpdated);
            this.adHocUser2TaskISOverdue.Activities.Add(this.logToHistoryListActivity97);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAdHocUser2ReviewTaskOverDue);
            this.adHocUser2TaskISOverdue.Condition = codecondition6;
            this.adHocUser2TaskISOverdue.Name = "adHocUser2TaskISOverdue";
            // 
            // adHocUser1TaskIsNOTOverdue
            // 
            this.adHocUser1TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity89);
            this.adHocUser1TaskIsNOTOverdue.Activities.Add(this.delayActivity10);
            this.adHocUser1TaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity90);
            this.adHocUser1TaskIsNOTOverdue.Name = "adHocUser1TaskIsNOTOverdue";
            // 
            // adHocUser1TaskISOverdue
            // 
            this.adHocUser1TaskISOverdue.Activities.Add(this.logToHistoryListActivity87);
            this.adHocUser1TaskISOverdue.Activities.Add(this.codeAdHocUser1reviewTaskExpired);
            this.adHocUser1TaskISOverdue.Activities.Add(this.adHocUser1TaskUpdated);
            this.adHocUser1TaskISOverdue.Activities.Add(this.onAdHocUser1ReviewTaskUpdated);
            this.adHocUser1TaskISOverdue.Activities.Add(this.logToHistoryListActivity88);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAdHocUser1ReviewTaskOverDue);
            this.adHocUser1TaskISOverdue.Condition = codecondition7;
            this.adHocUser1TaskISOverdue.Name = "adHocUser1TaskISOverdue";
            // 
            // agmPoliceReviewIsNOTOverdue
            // 
            this.agmPoliceReviewIsNOTOverdue.Activities.Add(this.logToHistoryListActivity80);
            this.agmPoliceReviewIsNOTOverdue.Activities.Add(this.delayActivity9);
            this.agmPoliceReviewIsNOTOverdue.Activities.Add(this.logToHistoryListActivity81);
            this.agmPoliceReviewIsNOTOverdue.Name = "agmPoliceReviewIsNOTOverdue";
            // 
            // agmPoliceReviewISOverdue
            // 
            this.agmPoliceReviewISOverdue.Activities.Add(this.logToHistoryListActivity78);
            this.agmPoliceReviewISOverdue.Activities.Add(this.codeAGMPoliceReviewExpired);
            this.agmPoliceReviewISOverdue.Activities.Add(this.agmPoliceReviewTaskUpdated);
            this.agmPoliceReviewISOverdue.Activities.Add(this.onAGMPoliceReviewTaskUpdated);
            this.agmPoliceReviewISOverdue.Activities.Add(this.logToHistoryListActivity79);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMPoliceReviewTaskOverDue);
            this.agmPoliceReviewISOverdue.Condition = codecondition8;
            this.agmPoliceReviewISOverdue.Name = "agmPoliceReviewISOverdue";
            // 
            // agmCommunicationsIsNOTOverdue
            // 
            this.agmCommunicationsIsNOTOverdue.Activities.Add(this.logToHistoryListActivity71);
            this.agmCommunicationsIsNOTOverdue.Activities.Add(this.delayActivity8);
            this.agmCommunicationsIsNOTOverdue.Activities.Add(this.logToHistoryListActivity72);
            this.agmCommunicationsIsNOTOverdue.Name = "agmCommunicationsIsNOTOverdue";
            // 
            // agmCommunicationsReviewISOverdue
            // 
            this.agmCommunicationsReviewISOverdue.Activities.Add(this.logToHistoryListActivity69);
            this.agmCommunicationsReviewISOverdue.Activities.Add(this.codeAGMCommunicationsReviewExpired);
            this.agmCommunicationsReviewISOverdue.Activities.Add(this.agmCommunicationsReviewTaskUpdated);
            this.agmCommunicationsReviewISOverdue.Activities.Add(this.onAGMCommunicationsReviewTaskUpdated);
            this.agmCommunicationsReviewISOverdue.Activities.Add(this.logToHistoryListActivity70);
            codecondition9.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMCommunicationsReviewTaskOverDue);
            this.agmCommunicationsReviewISOverdue.Condition = codecondition9;
            this.agmCommunicationsReviewISOverdue.Name = "agmCommunicationsReviewISOverdue";
            // 
            // agmAuditReviewTaskIsNOTOverdue
            // 
            this.agmAuditReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity62);
            this.agmAuditReviewTaskIsNOTOverdue.Activities.Add(this.delayActivity7);
            this.agmAuditReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity63);
            this.agmAuditReviewTaskIsNOTOverdue.Name = "agmAuditReviewTaskIsNOTOverdue";
            // 
            // agmAuditReviewTaskISOverdue
            // 
            this.agmAuditReviewTaskISOverdue.Activities.Add(this.logToHistoryListActivity60);
            this.agmAuditReviewTaskISOverdue.Activities.Add(this.codeAGMAuditReviewExpired);
            this.agmAuditReviewTaskISOverdue.Activities.Add(this.agmAuditReviewTaskUpdate);
            this.agmAuditReviewTaskISOverdue.Activities.Add(this.onAGMAuditReviewTaskUpdated);
            this.agmAuditReviewTaskISOverdue.Activities.Add(this.logToHistoryListActivity61);
            codecondition10.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMAuditReviewTaskOverDue);
            this.agmAuditReviewTaskISOverdue.Condition = codecondition10;
            this.agmAuditReviewTaskISOverdue.Name = "agmAuditReviewTaskISOverdue";
            // 
            // agmContractsReviewIsNOTOverdue
            // 
            this.agmContractsReviewIsNOTOverdue.Activities.Add(this.logToHistoryListActivity53);
            this.agmContractsReviewIsNOTOverdue.Activities.Add(this.delayActivity6);
            this.agmContractsReviewIsNOTOverdue.Activities.Add(this.logToHistoryListActivity54);
            this.agmContractsReviewIsNOTOverdue.Name = "agmContractsReviewIsNOTOverdue";
            // 
            // agmContractsReviewISOverdue
            // 
            this.agmContractsReviewISOverdue.Activities.Add(this.logToHistoryListActivity51);
            this.agmContractsReviewISOverdue.Activities.Add(this.codeAGMContractsReviewExpired);
            this.agmContractsReviewISOverdue.Activities.Add(this.agmContractsReviewTaskUpdated);
            this.agmContractsReviewISOverdue.Activities.Add(this.onAGMContractsReviewTaskUpdated);
            this.agmContractsReviewISOverdue.Activities.Add(this.logToHistoryListActivity52);
            codecondition11.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMContractsReviewTaskOverDue);
            this.agmContractsReviewISOverdue.Condition = codecondition11;
            this.agmContractsReviewISOverdue.Name = "agmContractsReviewISOverdue";
            // 
            // ifElseBranchActivity15
            // 
            this.ifElseBranchActivity15.Activities.Add(this.logToHistoryListActivity44);
            this.ifElseBranchActivity15.Activities.Add(this.delayActivity5);
            this.ifElseBranchActivity15.Activities.Add(this.logToHistoryListActivity45);
            this.ifElseBranchActivity15.Name = "ifElseBranchActivity15";
            // 
            // agmLegalReviewTaskIsOverdue
            // 
            this.agmLegalReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity42);
            this.agmLegalReviewTaskIsOverdue.Activities.Add(this.codeAGMLegalReviewExpired);
            this.agmLegalReviewTaskIsOverdue.Activities.Add(this.agmLegalReviewTaskUpdate);
            this.agmLegalReviewTaskIsOverdue.Activities.Add(this.onAGMLegalReviewTaskUpdated);
            this.agmLegalReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity43);
            codecondition12.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMLegalReviewTaskOverDue);
            this.agmLegalReviewTaskIsOverdue.Condition = codecondition12;
            this.agmLegalReviewTaskIsOverdue.Name = "agmLegalReviewTaskIsOverdue";
            // 
            // agmSafetyReviewTaskIsNotOverdue
            // 
            this.agmSafetyReviewTaskIsNotOverdue.Activities.Add(this.logToHistoryListActivity35);
            this.agmSafetyReviewTaskIsNotOverdue.Activities.Add(this.delayActivity4);
            this.agmSafetyReviewTaskIsNotOverdue.Activities.Add(this.logToHistoryListActivity36);
            this.agmSafetyReviewTaskIsNotOverdue.Name = "agmSafetyReviewTaskIsNotOverdue";
            // 
            // agmSafetyReviewTaskIsOverdue
            // 
            this.agmSafetyReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity33);
            this.agmSafetyReviewTaskIsOverdue.Activities.Add(this.codeAGMSafetyReviewExpired);
            this.agmSafetyReviewTaskIsOverdue.Activities.Add(this.agmSafetyReviewTaskUpdate);
            this.agmSafetyReviewTaskIsOverdue.Activities.Add(this.onAGMSafetyReviewTaskUpdated);
            this.agmSafetyReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity34);
            codecondition13.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMSafetyReviewTaskOverDue);
            this.agmSafetyReviewTaskIsOverdue.Condition = codecondition13;
            this.agmSafetyReviewTaskIsOverdue.Name = "agmSafetyReviewTaskIsOverdue";
            // 
            // agmHumanResourcesTaskIsNOTOverdue
            // 
            this.agmHumanResourcesTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity26);
            this.agmHumanResourcesTaskIsNOTOverdue.Activities.Add(this.delayActivity3);
            this.agmHumanResourcesTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity27);
            this.agmHumanResourcesTaskIsNOTOverdue.Name = "agmHumanResourcesTaskIsNOTOverdue";
            // 
            // agmHumanResourcesTaskIsOverdue
            // 
            this.agmHumanResourcesTaskIsOverdue.Activities.Add(this.logToHistoryListActivity24);
            this.agmHumanResourcesTaskIsOverdue.Activities.Add(this.codeAGMHumanResourcesTaskExpired);
            this.agmHumanResourcesTaskIsOverdue.Activities.Add(this.agmHumanResourcesTaskUpdate);
            this.agmHumanResourcesTaskIsOverdue.Activities.Add(this.onAGMHumanResourcesTaskUpdated);
            this.agmHumanResourcesTaskIsOverdue.Activities.Add(this.logToHistoryListActivity25);
            codecondition14.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMHumanResourcesReviewTaskOverDue);
            this.agmHumanResourcesTaskIsOverdue.Condition = codecondition14;
            this.agmHumanResourcesTaskIsOverdue.Name = "agmHumanResourcesTaskIsOverdue";
            // 
            // agmPlanningReviewTaskIsNOTOverdue
            // 
            this.agmPlanningReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity17);
            this.agmPlanningReviewTaskIsNOTOverdue.Activities.Add(this.delayActivity2);
            this.agmPlanningReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity18);
            this.agmPlanningReviewTaskIsNOTOverdue.Name = "agmPlanningReviewTaskIsNOTOverdue";
            // 
            // agmPlanningReviewTaskIsOverdue
            // 
            this.agmPlanningReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity15);
            this.agmPlanningReviewTaskIsOverdue.Activities.Add(this.codeAGMPlanningReviewTaskExpired);
            this.agmPlanningReviewTaskIsOverdue.Activities.Add(this.agmPlanningReviewTaskUpdate);
            this.agmPlanningReviewTaskIsOverdue.Activities.Add(this.onagmPlanningReviewTaskUpdated);
            this.agmPlanningReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity16);
            codecondition15.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMPlanningReviewTaskOverDue);
            this.agmPlanningReviewTaskIsOverdue.Condition = codecondition15;
            this.agmPlanningReviewTaskIsOverdue.Name = "agmPlanningReviewTaskIsOverdue";
            // 
            // agmITReviewTaskIsNOTOverdue
            // 
            this.agmITReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity8);
            this.agmITReviewTaskIsNOTOverdue.Activities.Add(this.delayActivity1);
            this.agmITReviewTaskIsNOTOverdue.Activities.Add(this.logToHistoryListActivity9);
            this.agmITReviewTaskIsNOTOverdue.Name = "agmITReviewTaskIsNOTOverdue";
            // 
            // agmITReviewTaskIsOverdue
            // 
            this.agmITReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity6);
            this.agmITReviewTaskIsOverdue.Activities.Add(this.codeAGMITReviewTaskExpired);
            this.agmITReviewTaskIsOverdue.Activities.Add(this.agmITReviewTaskUpdate);
            this.agmITReviewTaskIsOverdue.Activities.Add(this.onAGMITReviewTaskUpdated);
            this.agmITReviewTaskIsOverdue.Activities.Add(this.logToHistoryListActivity7);
            codecondition16.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMITReviewTaskOverDue);
            this.agmITReviewTaskIsOverdue.Condition = codecondition16;
            this.agmITReviewTaskIsOverdue.Name = "agmITReviewTaskIsOverdue";
            // 
            // agmFinanceReviewTaskIsNotOverdue
            // 
            this.agmFinanceReviewTaskIsNotOverdue.Activities.Add(this.logAGMFinanceReviewDelayStart);
            this.agmFinanceReviewTaskIsNotOverdue.Activities.Add(this.delayActivityForAGMFinanceReviewTask);
            this.agmFinanceReviewTaskIsNotOverdue.Activities.Add(this.logAGMFinanceReviewDelayEnd);
            this.agmFinanceReviewTaskIsNotOverdue.Name = "agmFinanceReviewTaskIsNotOverdue";
            // 
            // agmFinanceReviewTaskIsOverdue
            // 
            this.agmFinanceReviewTaskIsOverdue.Activities.Add(this.logAGMFinanceReviewTaskExpired);
            this.agmFinanceReviewTaskIsOverdue.Activities.Add(this.codeAGMFinanceReviewTaskExpired);
            this.agmFinanceReviewTaskIsOverdue.Activities.Add(this.agmFinanceReviewTaskUpdate);
            this.agmFinanceReviewTaskIsOverdue.Activities.Add(this.onAGMFinanceReviewTaskUpdated);
            this.agmFinanceReviewTaskIsOverdue.Activities.Add(this.logAGMFinanceReviewTaskMarkedExpired);
            codecondition17.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAGMFinanceReviewTaskOverDue);
            this.agmFinanceReviewTaskIsOverdue.Condition = codecondition17;
            this.agmFinanceReviewTaskIsOverdue.Name = "agmFinanceReviewTaskIsOverdue";
            // 
            // ifElseBranchActivity38
            // 
            this.ifElseBranchActivity38.Activities.Add(this.logToHistoryListActivity154);
            ruleconditionreference7.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity38.Condition = ruleconditionreference7;
            this.ifElseBranchActivity38.Name = "ifElseBranchActivity38";
            // 
            // ifElseBranchActivity37
            // 
            this.ifElseBranchActivity37.Activities.Add(this.logToHistoryListActivity151);
            this.ifElseBranchActivity37.Activities.Add(this.executiveDirectorReviewTask);
            this.ifElseBranchActivity37.Activities.Add(this.sendEmailExecutiveDirectorAdmin);
            this.ifElseBranchActivity37.Activities.Add(this.logToHistoryListActivity152);
            this.ifElseBranchActivity37.Activities.Add(this.whileActivity1);
            this.ifElseBranchActivity37.Activities.Add(this.executiveDirectorReviewTaskCompleted);
            this.ifElseBranchActivity37.Activities.Add(this.logToHistoryListActivity153);
            this.ifElseBranchActivity37.Activities.Add(this.conditionedActivityGroup5);
            ruleconditionreference8.ConditionName = "Check if Executive Director Review is required";
            this.ifElseBranchActivity37.Condition = ruleconditionreference8;
            this.ifElseBranchActivity37.Name = "ifElseBranchActivity37";
            // 
            // logToHistoryListActivity130
            // 
            this.logToHistoryListActivity130.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity130.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity130.HistoryDescription = "AGM Rail Operations was NOT selected";
            this.logToHistoryListActivity130.HistoryOutcome = "";
            this.logToHistoryListActivity130.Name = "logToHistoryListActivity130";
            this.logToHistoryListActivity130.OtherData = "";
            this.logToHistoryListActivity130.UserId = -1;
            // 
            // conditionedActivityGroup2
            // 
            this.conditionedActivityGroup2.Activities.Add(this.sequenceActivity80);
            this.conditionedActivityGroup2.Activities.Add(this.sequenceActivity81);
            this.conditionedActivityGroup2.Activities.Add(this.sequenceActivity82);
            this.conditionedActivityGroup2.Enabled = false;
            this.conditionedActivityGroup2.Name = "conditionedActivityGroup2";
            ruleconditionreference9.ConditionName = "AGM Finance Review Task IS completed";
            this.conditionedActivityGroup2.UntilCondition = ruleconditionreference9;
            // 
            // logToHistoryListActivity129
            // 
            this.logToHistoryListActivity129.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity129.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity129.HistoryDescription = "AGM Rail Operations Review Task Completed";
            this.logToHistoryListActivity129.HistoryOutcome = "";
            this.logToHistoryListActivity129.Name = "logToHistoryListActivity129";
            this.logToHistoryListActivity129.OtherData = "";
            this.logToHistoryListActivity129.UserId = -1;
            // 
            // agmRailOperationsReviewTaskCompleted
            // 
            correlationtoken44.Name = "agmRailOperationsReviewTask";
            correlationtoken44.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmRailOperationsReviewTaskCompleted.CorrelationToken = correlationtoken44;
            this.agmRailOperationsReviewTaskCompleted.Name = "agmRailOperationsReviewTaskCompleted";
            activitybind109.Name = "BoardAgendaWorkflow";
            activitybind109.Path = "agmRailOperationsReviewTask_TaskId";
            this.agmRailOperationsReviewTaskCompleted.TaskOutcome = null;
            this.agmRailOperationsReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind109)));
            // 
            // whileAGMRailOperationsReviewTask
            // 
            this.whileAGMRailOperationsReviewTask.Activities.Add(this.onAGMRailOperationsReviewTaskChanged);
            ruleconditionreference10.ConditionName = "Check if AGM Rail Operations Review Task is complete";
            this.whileAGMRailOperationsReviewTask.Condition = ruleconditionreference10;
            this.whileAGMRailOperationsReviewTask.Name = "whileAGMRailOperationsReviewTask";
            // 
            // logToHistoryListActivity128
            // 
            this.logToHistoryListActivity128.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity128.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity128.HistoryDescription = "AGM Rail Operations Review TASK created";
            this.logToHistoryListActivity128.HistoryOutcome = "";
            this.logToHistoryListActivity128.Name = "logToHistoryListActivity128";
            this.logToHistoryListActivity128.OtherData = "";
            this.logToHistoryListActivity128.UserId = -1;
            // 
            // sendEmailAGMRailOpsAdmin
            // 
            this.sendEmailAGMRailOpsAdmin.BCC = null;
            this.sendEmailAGMRailOpsAdmin.Body = null;
            this.sendEmailAGMRailOpsAdmin.CC = null;
            correlationtoken45.Name = "workflowToken";
            correlationtoken45.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMRailOpsAdmin.CorrelationToken = correlationtoken45;
            this.sendEmailAGMRailOpsAdmin.From = null;
            this.sendEmailAGMRailOpsAdmin.Headers = null;
            this.sendEmailAGMRailOpsAdmin.IncludeStatus = false;
            this.sendEmailAGMRailOpsAdmin.Name = "sendEmailAGMRailOpsAdmin";
            this.sendEmailAGMRailOpsAdmin.Subject = null;
            this.sendEmailAGMRailOpsAdmin.To = null;
            this.sendEmailAGMRailOpsAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMRailOpsAdmin_MethodInvoking);
            // 
            // agmRailOperationsReviewTask
            // 
            this.agmRailOperationsReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken46.Name = "agmRailOperationsReviewTask";
            correlationtoken46.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmRailOperationsReviewTask.CorrelationToken = correlationtoken46;
            this.agmRailOperationsReviewTask.ListItemId = -1;
            this.agmRailOperationsReviewTask.Name = "agmRailOperationsReviewTask";
            this.agmRailOperationsReviewTask.SpecialPermissions = null;
            activitybind110.Name = "BoardAgendaWorkflow";
            activitybind110.Path = "agmRailOperationsReviewTask_TaskId";
            activitybind111.Name = "BoardAgendaWorkflow";
            activitybind111.Path = "agmRailOperationsReviewTask_TaskProperties";
            this.agmRailOperationsReviewTask.MethodInvoking += new System.EventHandler(this.agmRailOperationsReviewTask_MethodInvoking);
            this.agmRailOperationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind111)));
            this.agmRailOperationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind110)));
            // 
            // logToHistoryListActivity127
            // 
            this.logToHistoryListActivity127.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity127.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity127.HistoryDescription = "Creating AGM-Rail Operations Review Task";
            this.logToHistoryListActivity127.HistoryOutcome = "";
            this.logToHistoryListActivity127.Name = "logToHistoryListActivity127";
            this.logToHistoryListActivity127.OtherData = "";
            this.logToHistoryListActivity127.UserId = -1;
            // 
            // logToHistoryListActivity121
            // 
            this.logToHistoryListActivity121.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity121.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity121.HistoryDescription = "AGM Rail Operations was NOT selected";
            this.logToHistoryListActivity121.HistoryOutcome = "";
            this.logToHistoryListActivity121.Name = "logToHistoryListActivity121";
            this.logToHistoryListActivity121.OtherData = "";
            this.logToHistoryListActivity121.UserId = -1;
            // 
            // conditionedActivityGroup1
            // 
            this.conditionedActivityGroup1.Activities.Add(this.sequenceActivity77);
            this.conditionedActivityGroup1.Activities.Add(this.sequenceActivity78);
            this.conditionedActivityGroup1.Activities.Add(this.sequenceActivity79);
            this.conditionedActivityGroup1.Enabled = false;
            this.conditionedActivityGroup1.Name = "conditionedActivityGroup1";
            ruleconditionreference11.ConditionName = "AGM Finance Review Task IS completed";
            this.conditionedActivityGroup1.UntilCondition = ruleconditionreference11;
            // 
            // logToHistoryListActivity120
            // 
            this.logToHistoryListActivity120.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity120.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity120.HistoryDescription = "AGM Bus Operations Review Task Completed";
            this.logToHistoryListActivity120.HistoryOutcome = "";
            this.logToHistoryListActivity120.Name = "logToHistoryListActivity120";
            this.logToHistoryListActivity120.OtherData = "";
            this.logToHistoryListActivity120.UserId = -1;
            // 
            // agmBusOperationsReviewTaskCompleted
            // 
            correlationtoken47.Name = "agmBusOperationsReviewTask";
            correlationtoken47.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmBusOperationsReviewTaskCompleted.CorrelationToken = correlationtoken47;
            this.agmBusOperationsReviewTaskCompleted.Name = "agmBusOperationsReviewTaskCompleted";
            activitybind112.Name = "BoardAgendaWorkflow";
            activitybind112.Path = "agmBusOperationsReviewTask_TaskId";
            this.agmBusOperationsReviewTaskCompleted.TaskOutcome = null;
            this.agmBusOperationsReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind112)));
            // 
            // whileAGMBusOperationsReviewTaskNOTComplete
            // 
            this.whileAGMBusOperationsReviewTaskNOTComplete.Activities.Add(this.onAGMBusOperationsReviewTaskChanged);
            ruleconditionreference12.ConditionName = "Check if AGM_BusOperations Review Task is complete";
            this.whileAGMBusOperationsReviewTaskNOTComplete.Condition = ruleconditionreference12;
            this.whileAGMBusOperationsReviewTaskNOTComplete.Name = "whileAGMBusOperationsReviewTaskNOTComplete";
            // 
            // logToHistoryListActivity119
            // 
            this.logToHistoryListActivity119.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity119.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity119.HistoryDescription = "AGM Finance Review TASK created";
            this.logToHistoryListActivity119.HistoryOutcome = "";
            this.logToHistoryListActivity119.Name = "logToHistoryListActivity119";
            this.logToHistoryListActivity119.OtherData = "";
            this.logToHistoryListActivity119.UserId = -1;
            // 
            // sendEmailAGMBusOpsAdmin
            // 
            this.sendEmailAGMBusOpsAdmin.BCC = null;
            this.sendEmailAGMBusOpsAdmin.Body = null;
            this.sendEmailAGMBusOpsAdmin.CC = null;
            correlationtoken48.Name = "workflowToken";
            correlationtoken48.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMBusOpsAdmin.CorrelationToken = correlationtoken48;
            this.sendEmailAGMBusOpsAdmin.From = null;
            this.sendEmailAGMBusOpsAdmin.Headers = null;
            this.sendEmailAGMBusOpsAdmin.IncludeStatus = false;
            this.sendEmailAGMBusOpsAdmin.Name = "sendEmailAGMBusOpsAdmin";
            this.sendEmailAGMBusOpsAdmin.Subject = null;
            this.sendEmailAGMBusOpsAdmin.To = null;
            this.sendEmailAGMBusOpsAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMBusOpsAdmin_MethodInvoking);
            // 
            // agmBusOperationsReviewTask
            // 
            this.agmBusOperationsReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken49.Name = "agmBusOperationsReviewTask";
            correlationtoken49.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmBusOperationsReviewTask.CorrelationToken = correlationtoken49;
            this.agmBusOperationsReviewTask.ListItemId = -1;
            this.agmBusOperationsReviewTask.Name = "agmBusOperationsReviewTask";
            this.agmBusOperationsReviewTask.SpecialPermissions = null;
            activitybind113.Name = "BoardAgendaWorkflow";
            activitybind113.Path = "agmBusOperationsReviewTask_TaskId";
            activitybind114.Name = "BoardAgendaWorkflow";
            activitybind114.Path = "agmBusOperationsReviewTask_TaskProperties";
            this.agmBusOperationsReviewTask.MethodInvoking += new System.EventHandler(this.agmBusOperationsReviewTask_MethodInvoking);
            this.agmBusOperationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind114)));
            this.agmBusOperationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind113)));
            // 
            // logToHistoryListActivity118
            // 
            this.logToHistoryListActivity118.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity118.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity118.HistoryDescription = "Creating AGM-Bus Operations Review Task";
            this.logToHistoryListActivity118.HistoryOutcome = "";
            this.logToHistoryListActivity118.Name = "logToHistoryListActivity118";
            this.logToHistoryListActivity118.OtherData = "";
            this.logToHistoryListActivity118.UserId = -1;
            // 
            // logToHistoryListActivity111
            // 
            this.logToHistoryListActivity111.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity111.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity111.HistoryDescription = "AdHoc User4 was NOT selected";
            this.logToHistoryListActivity111.HistoryOutcome = "";
            this.logToHistoryListActivity111.Name = "logToHistoryListActivity111";
            this.logToHistoryListActivity111.OtherData = "";
            this.logToHistoryListActivity111.UserId = -1;
            // 
            // CAGforAdHocUser4ReviewTask
            // 
            this.CAGforAdHocUser4ReviewTask.Activities.Add(this.sequenceActivity74);
            this.CAGforAdHocUser4ReviewTask.Activities.Add(this.sequenceActivity75);
            this.CAGforAdHocUser4ReviewTask.Activities.Add(this.sequenceActivity76);
            this.CAGforAdHocUser4ReviewTask.Enabled = false;
            this.CAGforAdHocUser4ReviewTask.Name = "CAGforAdHocUser4ReviewTask";
            ruleconditionreference13.ConditionName = "Adhoc User4 Review Task IS Complete";
            this.CAGforAdHocUser4ReviewTask.UntilCondition = ruleconditionreference13;
            // 
            // logToHistoryListActivity113
            // 
            this.logToHistoryListActivity113.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity113.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity113.HistoryDescription = "AdHocUser4 Review Task Completed";
            this.logToHistoryListActivity113.HistoryOutcome = "";
            this.logToHistoryListActivity113.Name = "logToHistoryListActivity113";
            this.logToHistoryListActivity113.OtherData = "";
            this.logToHistoryListActivity113.UserId = -1;
            // 
            // adHocUser4ReviewTaskCompleted
            // 
            correlationtoken50.Name = "adHocUser4ReviewTask";
            correlationtoken50.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser4ReviewTaskCompleted.CorrelationToken = correlationtoken50;
            this.adHocUser4ReviewTaskCompleted.Name = "adHocUser4ReviewTaskCompleted";
            activitybind115.Name = "BoardAgendaWorkflow";
            activitybind115.Path = "adHocUser4ReviewTask_TaskId";
            this.adHocUser4ReviewTaskCompleted.TaskOutcome = null;
            this.adHocUser4ReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind115)));
            // 
            // whileAdHocUser4ReviewTaskIsNOTComplete
            // 
            this.whileAdHocUser4ReviewTaskIsNOTComplete.Activities.Add(this.onAdHocUser4TaskChanged);
            ruleconditionreference14.ConditionName = "Check if Adhoc User4 Review Task is complete";
            this.whileAdHocUser4ReviewTaskIsNOTComplete.Condition = ruleconditionreference14;
            this.whileAdHocUser4ReviewTaskIsNOTComplete.Name = "whileAdHocUser4ReviewTaskIsNOTComplete";
            // 
            // logToHistoryListActivity110
            // 
            this.logToHistoryListActivity110.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity110.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity110.HistoryDescription = "Adhoc User4 Review TASK created";
            this.logToHistoryListActivity110.HistoryOutcome = "";
            this.logToHistoryListActivity110.Name = "logToHistoryListActivity110";
            this.logToHistoryListActivity110.OtherData = "";
            this.logToHistoryListActivity110.UserId = -1;
            // 
            // adHocUser4ReviewTask
            // 
            this.adHocUser4ReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken51.Name = "adHocUser4ReviewTask";
            correlationtoken51.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser4ReviewTask.CorrelationToken = correlationtoken51;
            this.adHocUser4ReviewTask.ListItemId = -1;
            this.adHocUser4ReviewTask.Name = "adHocUser4ReviewTask";
            this.adHocUser4ReviewTask.SpecialPermissions = null;
            activitybind116.Name = "BoardAgendaWorkflow";
            activitybind116.Path = "adHocUser4ReviewTask_TaskId";
            activitybind117.Name = "BoardAgendaWorkflow";
            activitybind117.Path = "adHocUser4ReviewTask_TaskProperties";
            this.adHocUser4ReviewTask.MethodInvoking += new System.EventHandler(this.adhocUser4ReviewTask_MethodInvoking);
            this.adHocUser4ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind117)));
            this.adHocUser4ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind116)));
            // 
            // logToHistoryListActivity109
            // 
            this.logToHistoryListActivity109.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity109.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity109.HistoryDescription = "Creating AdhocUser4 Review Task";
            this.logToHistoryListActivity109.HistoryOutcome = "";
            this.logToHistoryListActivity109.Name = "logToHistoryListActivity109";
            this.logToHistoryListActivity109.OtherData = "";
            this.logToHistoryListActivity109.UserId = -1;
            // 
            // ifElseActivity13
            // 
            this.ifElseActivity13.Activities.Add(this.adHocUser3TaskISOverdue);
            this.ifElseActivity13.Activities.Add(this.adHocUser3TaskIsNOTOverdue);
            this.ifElseActivity13.Name = "ifElseActivity13";
            // 
            // onAdHocUser3ReviewTaskCreated
            // 
            activitybind118.Name = "BoardAgendaWorkflow";
            activitybind118.Path = "onAdHocUser3ReviewTaskCreated_AfterProperties";
            correlationtoken52.Name = "adHocUser3ReviewTask";
            correlationtoken52.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser3ReviewTaskCreated.CorrelationToken = correlationtoken52;
            this.onAdHocUser3ReviewTaskCreated.Executor = null;
            this.onAdHocUser3ReviewTaskCreated.Name = "onAdHocUser3ReviewTaskCreated";
            activitybind119.Name = "BoardAgendaWorkflow";
            activitybind119.Path = "adHocUser3ReviewTask_TaskId";
            this.onAdHocUser3ReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser3ReviewTaskCreated_Invoked);
            this.onAdHocUser3ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind119)));
            this.onAdHocUser3ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind118)));
            // 
            // logToHistoryListActivity103
            // 
            this.logToHistoryListActivity103.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity103.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity103.HistoryDescription = "Creating AdhocUser3 Review Task(CAG)";
            this.logToHistoryListActivity103.HistoryOutcome = "";
            this.logToHistoryListActivity103.Name = "logToHistoryListActivity103";
            this.logToHistoryListActivity103.OtherData = "";
            this.logToHistoryListActivity103.UserId = -1;
            // 
            // ifElseActivity12
            // 
            this.ifElseActivity12.Activities.Add(this.adHocUser2TaskISOverdue);
            this.ifElseActivity12.Activities.Add(this.adHocUser2TaskIsNOTOverdue);
            this.ifElseActivity12.Name = "ifElseActivity12";
            // 
            // onAdHocUser2ReviewTaskCreated
            // 
            activitybind120.Name = "BoardAgendaWorkflow";
            activitybind120.Path = "onAdHocUser2ReviewTaskCreated_AfterProperties";
            correlationtoken53.Name = "adHocUser2ReviewTask";
            correlationtoken53.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser2ReviewTaskCreated.CorrelationToken = correlationtoken53;
            this.onAdHocUser2ReviewTaskCreated.Executor = null;
            this.onAdHocUser2ReviewTaskCreated.Name = "onAdHocUser2ReviewTaskCreated";
            activitybind121.Name = "BoardAgendaWorkflow";
            activitybind121.Path = "adHocUser2ReviewTask_TaskId";
            this.onAdHocUser2ReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser2ReviewTaskCreated_Invoked);
            this.onAdHocUser2ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind121)));
            this.onAdHocUser2ReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind120)));
            // 
            // logToHistoryListActivity94
            // 
            this.logToHistoryListActivity94.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity94.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity94.HistoryDescription = "Creating AdhocUser2 Review Task(CAG)";
            this.logToHistoryListActivity94.HistoryOutcome = "";
            this.logToHistoryListActivity94.Name = "logToHistoryListActivity94";
            this.logToHistoryListActivity94.OtherData = "";
            this.logToHistoryListActivity94.UserId = -1;
            // 
            // ifElseActivity11
            // 
            this.ifElseActivity11.Activities.Add(this.adHocUser1TaskISOverdue);
            this.ifElseActivity11.Activities.Add(this.adHocUser1TaskIsNOTOverdue);
            this.ifElseActivity11.Name = "ifElseActivity11";
            // 
            // onAdhocUser1TaskCreated
            // 
            activitybind122.Name = "BoardAgendaWorkflow";
            activitybind122.Path = "onAdhocUser1TaskCreated_AfterProperties";
            correlationtoken54.Name = "adHocUser1ReviewTask";
            correlationtoken54.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdhocUser1TaskCreated.CorrelationToken = correlationtoken54;
            this.onAdhocUser1TaskCreated.Executor = null;
            this.onAdhocUser1TaskCreated.Name = "onAdhocUser1TaskCreated";
            activitybind123.Name = "BoardAgendaWorkflow";
            activitybind123.Path = "adHocUser1ReviewTask_TaskId";
            this.onAdhocUser1TaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser1ReviewTaskCreated_Invoked);
            this.onAdhocUser1TaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind123)));
            this.onAdhocUser1TaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind122)));
            // 
            // logToHistoryListActivity85
            // 
            this.logToHistoryListActivity85.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity85.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity85.HistoryDescription = "Creating AdhocUser1 Review Task(CAG)";
            this.logToHistoryListActivity85.HistoryOutcome = "";
            this.logToHistoryListActivity85.Name = "logToHistoryListActivity85";
            this.logToHistoryListActivity85.OtherData = "";
            this.logToHistoryListActivity85.UserId = -1;
            // 
            // ifElseActivity10
            // 
            this.ifElseActivity10.Activities.Add(this.agmPoliceReviewISOverdue);
            this.ifElseActivity10.Activities.Add(this.agmPoliceReviewIsNOTOverdue);
            this.ifElseActivity10.Name = "ifElseActivity10";
            // 
            // onAGMPoliceTaskCreated
            // 
            activitybind124.Name = "BoardAgendaWorkflow";
            activitybind124.Path = "onAGMPoliceTaskCreated_AfterProperties";
            correlationtoken55.Name = "agmPoliceReviewTask";
            correlationtoken55.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMPoliceTaskCreated.CorrelationToken = correlationtoken55;
            this.onAGMPoliceTaskCreated.Executor = null;
            this.onAGMPoliceTaskCreated.Name = "onAGMPoliceTaskCreated";
            activitybind125.Name = "BoardAgendaWorkflow";
            activitybind125.Path = "agmPoliceReviewTask_TaskId";
            this.onAGMPoliceTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPoliceReviewTaskCreated_Invoked);
            this.onAGMPoliceTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind125)));
            this.onAGMPoliceTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind124)));
            // 
            // logToHistoryListActivity76
            // 
            this.logToHistoryListActivity76.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity76.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity76.HistoryDescription = "Creating AGM Police Review Task (CAG)";
            this.logToHistoryListActivity76.HistoryOutcome = "";
            this.logToHistoryListActivity76.Name = "logToHistoryListActivity76";
            this.logToHistoryListActivity76.OtherData = "";
            this.logToHistoryListActivity76.UserId = -1;
            // 
            // ifElseActivity8
            // 
            this.ifElseActivity8.Activities.Add(this.agmCommunicationsReviewISOverdue);
            this.ifElseActivity8.Activities.Add(this.agmCommunicationsIsNOTOverdue);
            this.ifElseActivity8.Name = "ifElseActivity8";
            // 
            // onAGMCommunicationsReviewTaskCreated
            // 
            activitybind126.Name = "BoardAgendaWorkflow";
            activitybind126.Path = "onAGMCommunicationsReviewTaskCreated_AfterProperties";
            correlationtoken56.Name = "agmCommunicationsReviewTask";
            correlationtoken56.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMCommunicationsReviewTaskCreated.CorrelationToken = correlationtoken56;
            this.onAGMCommunicationsReviewTaskCreated.Executor = null;
            this.onAGMCommunicationsReviewTaskCreated.Name = "onAGMCommunicationsReviewTaskCreated";
            activitybind127.Name = "BoardAgendaWorkflow";
            activitybind127.Path = "agmCommunicationsReviewTask_TaskId";
            this.onAGMCommunicationsReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMCommunicationsReviewTaskCreated_Invoked);
            this.onAGMCommunicationsReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind127)));
            this.onAGMCommunicationsReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind126)));
            // 
            // logToHistoryListActivity67
            // 
            this.logToHistoryListActivity67.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity67.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity67.HistoryDescription = "Creating AGM Communications Review Task";
            this.logToHistoryListActivity67.HistoryOutcome = "";
            this.logToHistoryListActivity67.Name = "logToHistoryListActivity67";
            this.logToHistoryListActivity67.OtherData = "";
            this.logToHistoryListActivity67.UserId = -1;
            // 
            // ifElseActivity9
            // 
            this.ifElseActivity9.Activities.Add(this.agmAuditReviewTaskISOverdue);
            this.ifElseActivity9.Activities.Add(this.agmAuditReviewTaskIsNOTOverdue);
            this.ifElseActivity9.Name = "ifElseActivity9";
            // 
            // onAGMAuditReviewTaskCreated
            // 
            activitybind128.Name = "BoardAgendaWorkflow";
            activitybind128.Path = "onAGMAuditReviewTaskCreated_AfterProperties";
            correlationtoken57.Name = "agmFinanceReviewTask";
            correlationtoken57.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMAuditReviewTaskCreated.CorrelationToken = correlationtoken57;
            this.onAGMAuditReviewTaskCreated.Executor = null;
            this.onAGMAuditReviewTaskCreated.Name = "onAGMAuditReviewTaskCreated";
            activitybind129.Name = "BoardAgendaWorkflow";
            activitybind129.Path = "agmAuditReviewTask_TaskId";
            this.onAGMAuditReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMAuditReviewTaskCreated_Invoked);
            this.onAGMAuditReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind129)));
            this.onAGMAuditReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind128)));
            // 
            // logToHistoryListActivity58
            // 
            this.logToHistoryListActivity58.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity58.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity58.HistoryDescription = "Creating AGM Audit Review Task";
            this.logToHistoryListActivity58.HistoryOutcome = "";
            this.logToHistoryListActivity58.Name = "logToHistoryListActivity58";
            this.logToHistoryListActivity58.OtherData = "";
            this.logToHistoryListActivity58.UserId = -1;
            // 
            // ifElseActivity6
            // 
            this.ifElseActivity6.Activities.Add(this.agmContractsReviewISOverdue);
            this.ifElseActivity6.Activities.Add(this.agmContractsReviewIsNOTOverdue);
            this.ifElseActivity6.Name = "ifElseActivity6";
            // 
            // onAGMContractsReviewTaskCreated
            // 
            activitybind130.Name = "BoardAgendaWorkflow";
            activitybind130.Path = "onAGMContractsReviewTaskCreated_AfterProperties";
            correlationtoken58.Name = "agmContractsReviewTask";
            correlationtoken58.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMContractsReviewTaskCreated.CorrelationToken = correlationtoken58;
            this.onAGMContractsReviewTaskCreated.Executor = null;
            this.onAGMContractsReviewTaskCreated.Name = "onAGMContractsReviewTaskCreated";
            activitybind131.Name = "BoardAgendaWorkflow";
            activitybind131.Path = "agmContractsReviewTask_TaskId";
            this.onAGMContractsReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMContractsReviewTaskCreated_Invoked);
            this.onAGMContractsReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind131)));
            this.onAGMContractsReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind130)));
            // 
            // logToHistoryListActivity49
            // 
            this.logToHistoryListActivity49.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity49.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity49.HistoryDescription = "Creating AGM Contracts Review Task";
            this.logToHistoryListActivity49.HistoryOutcome = "";
            this.logToHistoryListActivity49.Name = "logToHistoryListActivity49";
            this.logToHistoryListActivity49.OtherData = "";
            this.logToHistoryListActivity49.UserId = -1;
            // 
            // ifElseActivity7
            // 
            this.ifElseActivity7.Activities.Add(this.agmLegalReviewTaskIsOverdue);
            this.ifElseActivity7.Activities.Add(this.ifElseBranchActivity15);
            this.ifElseActivity7.Name = "ifElseActivity7";
            // 
            // onAGMLegalReviewTaskCompleted
            // 
            activitybind132.Name = "BoardAgendaWorkflow";
            activitybind132.Path = "onAGMLegalReviewTaskCompleted_AfterProperties";
            correlationtoken59.Name = "agmLegalReviewTask";
            correlationtoken59.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMLegalReviewTaskCompleted.CorrelationToken = correlationtoken59;
            this.onAGMLegalReviewTaskCompleted.Executor = null;
            this.onAGMLegalReviewTaskCompleted.Name = "onAGMLegalReviewTaskCompleted";
            activitybind133.Name = "BoardAgendaWorkflow";
            activitybind133.Path = "agmLegalReviewTask_TaskId";
            this.onAGMLegalReviewTaskCompleted.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMLegalReviewTaskCreated_Invoked);
            this.onAGMLegalReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind133)));
            this.onAGMLegalReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind132)));
            // 
            // logToHistoryListActivity40
            // 
            this.logToHistoryListActivity40.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity40.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity40.HistoryDescription = "Creating AGM Legal Review Task";
            this.logToHistoryListActivity40.HistoryOutcome = "";
            this.logToHistoryListActivity40.Name = "logToHistoryListActivity40";
            this.logToHistoryListActivity40.OtherData = "";
            this.logToHistoryListActivity40.UserId = -1;
            // 
            // ifElseActivity4
            // 
            this.ifElseActivity4.Activities.Add(this.agmSafetyReviewTaskIsOverdue);
            this.ifElseActivity4.Activities.Add(this.agmSafetyReviewTaskIsNotOverdue);
            this.ifElseActivity4.Name = "ifElseActivity4";
            // 
            // onAGMSafetyReviewTaskCreated
            // 
            activitybind134.Name = "BoardAgendaWorkflow";
            activitybind134.Path = "onAGMSafetyReviewTaskCreated_AfterProperties";
            correlationtoken60.Name = "agmSafetyReviewTask";
            correlationtoken60.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMSafetyReviewTaskCreated.CorrelationToken = correlationtoken60;
            this.onAGMSafetyReviewTaskCreated.Executor = null;
            this.onAGMSafetyReviewTaskCreated.Name = "onAGMSafetyReviewTaskCreated";
            activitybind135.Name = "BoardAgendaWorkflow";
            activitybind135.Path = "agmSafetyReviewTask_TaskId";
            this.onAGMSafetyReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMSafetyReviewTaskCreated_Invoked);
            this.onAGMSafetyReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind135)));
            this.onAGMSafetyReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind134)));
            // 
            // logToHistoryListActivity31
            // 
            this.logToHistoryListActivity31.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity31.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity31.HistoryDescription = "Creating AGM Safety Review Task";
            this.logToHistoryListActivity31.HistoryOutcome = "";
            this.logToHistoryListActivity31.Name = "logToHistoryListActivity31";
            this.logToHistoryListActivity31.OtherData = "";
            this.logToHistoryListActivity31.UserId = -1;
            // 
            // ifElseActivity5
            // 
            this.ifElseActivity5.Activities.Add(this.agmHumanResourcesTaskIsOverdue);
            this.ifElseActivity5.Activities.Add(this.agmHumanResourcesTaskIsNOTOverdue);
            this.ifElseActivity5.Name = "ifElseActivity5";
            // 
            // onAGMHumanResourcesReviewTaskCreated
            // 
            activitybind136.Name = "BoardAgendaWorkflow";
            activitybind136.Path = "onAGMHumanResourcesReviewTaskCreated_AfterProperties";
            correlationtoken61.Name = "agmHumanResourcesReviewTask";
            correlationtoken61.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMHumanResourcesReviewTaskCreated.CorrelationToken = correlationtoken61;
            this.onAGMHumanResourcesReviewTaskCreated.Executor = null;
            this.onAGMHumanResourcesReviewTaskCreated.Name = "onAGMHumanResourcesReviewTaskCreated";
            activitybind137.Name = "BoardAgendaWorkflow";
            activitybind137.Path = "agmHumanResourcesReviewTask_TaskId";
            this.onAGMHumanResourcesReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMHumanResourcesReviewTaskCreated_Invoked);
            this.onAGMHumanResourcesReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind137)));
            this.onAGMHumanResourcesReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind136)));
            // 
            // logToHistoryListActivity22
            // 
            this.logToHistoryListActivity22.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity22.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity22.HistoryDescription = "Creating AGM Human Resources Review Task";
            this.logToHistoryListActivity22.HistoryOutcome = "";
            this.logToHistoryListActivity22.Name = "logToHistoryListActivity22";
            this.logToHistoryListActivity22.OtherData = "";
            this.logToHistoryListActivity22.UserId = -1;
            // 
            // ifElseActivity3
            // 
            this.ifElseActivity3.Activities.Add(this.agmPlanningReviewTaskIsOverdue);
            this.ifElseActivity3.Activities.Add(this.agmPlanningReviewTaskIsNOTOverdue);
            this.ifElseActivity3.Name = "ifElseActivity3";
            // 
            // onAGMPlanningReviewTaskCreated
            // 
            activitybind138.Name = "BoardAgendaWorkflow";
            activitybind138.Path = "onAGMPlanningReviewTaskCreated_AfterProperties";
            correlationtoken62.Name = "agmPlanningReviewTask";
            correlationtoken62.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMPlanningReviewTaskCreated.CorrelationToken = correlationtoken62;
            this.onAGMPlanningReviewTaskCreated.Executor = null;
            this.onAGMPlanningReviewTaskCreated.Name = "onAGMPlanningReviewTaskCreated";
            activitybind139.Name = "BoardAgendaWorkflow";
            activitybind139.Path = "agmPlanningReviewTask_TaskId";
            this.onAGMPlanningReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPlanningReviewTaskCreated_Invoked);
            this.onAGMPlanningReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind139)));
            this.onAGMPlanningReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind138)));
            // 
            // logToHistoryListActivity13
            // 
            this.logToHistoryListActivity13.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity13.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity13.HistoryDescription = "Creating AGM Planning Review Task";
            this.logToHistoryListActivity13.HistoryOutcome = "";
            this.logToHistoryListActivity13.Name = "logToHistoryListActivity13";
            this.logToHistoryListActivity13.OtherData = "";
            this.logToHistoryListActivity13.UserId = -1;
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.agmITReviewTaskIsOverdue);
            this.ifElseActivity2.Activities.Add(this.agmITReviewTaskIsNOTOverdue);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // onAGMITReviewTaskCreated
            // 
            activitybind140.Name = "BoardAgendaWorkflow";
            activitybind140.Path = "onAGMITReviewTaskCreated_AfterProperties";
            correlationtoken63.Name = "agmITReviewTask";
            correlationtoken63.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMITReviewTaskCreated.CorrelationToken = correlationtoken63;
            this.onAGMITReviewTaskCreated.Executor = null;
            this.onAGMITReviewTaskCreated.Name = "onAGMITReviewTaskCreated";
            activitybind141.Name = "BoardAgendaWorkflow";
            activitybind141.Path = "agmITReviewTask_TaskId";
            this.onAGMITReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMITReviewTaskCreated_Invoked);
            this.onAGMITReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind141)));
            this.onAGMITReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind140)));
            // 
            // logToHistoryListActivity4
            // 
            this.logToHistoryListActivity4.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity4.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity4.HistoryDescription = "Creating AGM IT Review Task";
            this.logToHistoryListActivity4.HistoryOutcome = "";
            this.logToHistoryListActivity4.Name = "logToHistoryListActivity4";
            this.logToHistoryListActivity4.OtherData = "";
            this.logToHistoryListActivity4.UserId = -1;
            // 
            // ifAGMReviewTaskOverdue
            // 
            this.ifAGMReviewTaskOverdue.Activities.Add(this.agmFinanceReviewTaskIsOverdue);
            this.ifAGMReviewTaskOverdue.Activities.Add(this.agmFinanceReviewTaskIsNotOverdue);
            this.ifAGMReviewTaskOverdue.Name = "ifAGMReviewTaskOverdue";
            // 
            // onAGMFinanceReviewTaskCreated
            // 
            activitybind142.Name = "BoardAgendaWorkflow";
            activitybind142.Path = "onAGMFinanceReviewTaskCreated_AfterProperties";
            correlationtoken64.Name = "agmFinanceReviewTask";
            correlationtoken64.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMFinanceReviewTaskCreated.CorrelationToken = correlationtoken64;
            this.onAGMFinanceReviewTaskCreated.Executor = null;
            this.onAGMFinanceReviewTaskCreated.Name = "onAGMFinanceReviewTaskCreated";
            activitybind143.Name = "BoardAgendaWorkflow";
            activitybind143.Path = "agmFinanceReviewTask_TaskId";
            this.onAGMFinanceReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMFinanceReviewTaskCreated_Invoked);
            this.onAGMFinanceReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind143)));
            this.onAGMFinanceReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind142)));
            // 
            // logAGMFinanceReviewTaskCreatedInSequence
            // 
            this.logAGMFinanceReviewTaskCreatedInSequence.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewTaskCreatedInSequence.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewTaskCreatedInSequence.HistoryDescription = "Creating AGM Finance Review Task";
            this.logAGMFinanceReviewTaskCreatedInSequence.HistoryOutcome = "";
            this.logAGMFinanceReviewTaskCreatedInSequence.Name = "logAGMFinanceReviewTaskCreatedInSequence";
            this.logAGMFinanceReviewTaskCreatedInSequence.OtherData = "";
            this.logAGMFinanceReviewTaskCreatedInSequence.UserId = -1;
            // 
            // ifElseExecutiveDirectorSelected
            // 
            this.ifElseExecutiveDirectorSelected.Activities.Add(this.ifElseBranchActivity37);
            this.ifElseExecutiveDirectorSelected.Activities.Add(this.ifElseBranchActivity38);
            this.ifElseExecutiveDirectorSelected.Description = "IF Executive Director review is required for this document set";
            this.ifElseExecutiveDirectorSelected.Name = "ifElseExecutiveDirectorSelected";
            // 
            // ifElseBranchActivity34
            // 
            this.ifElseBranchActivity34.Activities.Add(this.logToHistoryListActivity130);
            ruleconditionreference15.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity34.Condition = ruleconditionreference15;
            this.ifElseBranchActivity34.Name = "ifElseBranchActivity34";
            // 
            // ifElseBranchActivity33
            // 
            this.ifElseBranchActivity33.Activities.Add(this.logToHistoryListActivity127);
            this.ifElseBranchActivity33.Activities.Add(this.agmRailOperationsReviewTask);
            this.ifElseBranchActivity33.Activities.Add(this.sendEmailAGMRailOpsAdmin);
            this.ifElseBranchActivity33.Activities.Add(this.logToHistoryListActivity128);
            this.ifElseBranchActivity33.Activities.Add(this.whileAGMRailOperationsReviewTask);
            this.ifElseBranchActivity33.Activities.Add(this.agmRailOperationsReviewTaskCompleted);
            this.ifElseBranchActivity33.Activities.Add(this.logToHistoryListActivity129);
            this.ifElseBranchActivity33.Activities.Add(this.conditionedActivityGroup2);
            ruleconditionreference16.ConditionName = "Check if AGM-RailOperations review required";
            this.ifElseBranchActivity33.Condition = ruleconditionreference16;
            this.ifElseBranchActivity33.Name = "ifElseBranchActivity33";
            // 
            // ifElseBranchActivity30
            // 
            this.ifElseBranchActivity30.Activities.Add(this.logToHistoryListActivity121);
            ruleconditionreference17.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity30.Condition = ruleconditionreference17;
            this.ifElseBranchActivity30.Name = "ifElseBranchActivity30";
            // 
            // ifElseBranchActivity29
            // 
            this.ifElseBranchActivity29.Activities.Add(this.logToHistoryListActivity118);
            this.ifElseBranchActivity29.Activities.Add(this.agmBusOperationsReviewTask);
            this.ifElseBranchActivity29.Activities.Add(this.sendEmailAGMBusOpsAdmin);
            this.ifElseBranchActivity29.Activities.Add(this.logToHistoryListActivity119);
            this.ifElseBranchActivity29.Activities.Add(this.whileAGMBusOperationsReviewTaskNOTComplete);
            this.ifElseBranchActivity29.Activities.Add(this.agmBusOperationsReviewTaskCompleted);
            this.ifElseBranchActivity29.Activities.Add(this.logToHistoryListActivity120);
            this.ifElseBranchActivity29.Activities.Add(this.conditionedActivityGroup1);
            ruleconditionreference18.ConditionName = "Check if AGM-Bus Operations review required";
            this.ifElseBranchActivity29.Condition = ruleconditionreference18;
            this.ifElseBranchActivity29.Name = "ifElseBranchActivity29";
            // 
            // ifElseBranchActivity28
            // 
            this.ifElseBranchActivity28.Activities.Add(this.logToHistoryListActivity111);
            ruleconditionreference19.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity28.Condition = ruleconditionreference19;
            this.ifElseBranchActivity28.Name = "ifElseBranchActivity28";
            // 
            // ifElseBranchActivity27
            // 
            this.ifElseBranchActivity27.Activities.Add(this.logToHistoryListActivity109);
            this.ifElseBranchActivity27.Activities.Add(this.adHocUser4ReviewTask);
            this.ifElseBranchActivity27.Activities.Add(this.logToHistoryListActivity110);
            this.ifElseBranchActivity27.Activities.Add(this.whileAdHocUser4ReviewTaskIsNOTComplete);
            this.ifElseBranchActivity27.Activities.Add(this.adHocUser4ReviewTaskCompleted);
            this.ifElseBranchActivity27.Activities.Add(this.logToHistoryListActivity113);
            this.ifElseBranchActivity27.Activities.Add(this.CAGforAdHocUser4ReviewTask);
            ruleconditionreference20.ConditionName = "Check if Adhoc User4 is selected";
            this.ifElseBranchActivity27.Condition = ruleconditionreference20;
            this.ifElseBranchActivity27.Name = "ifElseBranchActivity27";
            ruleconditionreference21.ConditionName = "AdHoc User3 Task Created But not Completed";
            // 
            // sequenceActivity73
            // 
            this.sequenceActivity73.Activities.Add(this.ifElseActivity13);
            this.sequenceActivity73.Name = "sequenceActivity73";
            this.sequenceActivity73.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference21);
            // 
            // sequenceActivity72
            // 
            this.sequenceActivity72.Name = "sequenceActivity72";
            // 
            // sequenceActivity71
            // 
            this.sequenceActivity71.Activities.Add(this.logToHistoryListActivity103);
            this.sequenceActivity71.Activities.Add(this.onAdHocUser3ReviewTaskCreated);
            this.sequenceActivity71.Name = "sequenceActivity71";
            // 
            // onAdHocUser3TaskChanged
            // 
            activitybind144.Name = "BoardAgendaWorkflow";
            activitybind144.Path = "onAdHocUser3TaskChanged_AfterProperties";
            activitybind145.Name = "BoardAgendaWorkflow";
            activitybind145.Path = "onAdHocUser3TaskChanged_BeforeProperties";
            correlationtoken65.Name = "adHocUser3ReviewTask";
            correlationtoken65.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser3TaskChanged.CorrelationToken = correlationtoken65;
            this.onAdHocUser3TaskChanged.Executor = null;
            this.onAdHocUser3TaskChanged.Name = "onAdHocUser3TaskChanged";
            activitybind146.Name = "BoardAgendaWorkflow";
            activitybind146.Path = "adHocUser3ReviewTask_TaskId";
            this.onAdHocUser3TaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser3ReviewTaskChanged_Invoked);
            this.onAdHocUser3TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind145)));
            this.onAdHocUser3TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind146)));
            this.onAdHocUser3TaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind144)));
            ruleconditionreference22.ConditionName = "Adhoc User2 Task Created BUT Not Completed";
            // 
            // sequenceActivity70
            // 
            this.sequenceActivity70.Activities.Add(this.ifElseActivity12);
            this.sequenceActivity70.Name = "sequenceActivity70";
            this.sequenceActivity70.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference22);
            // 
            // sequenceActivity69
            // 
            this.sequenceActivity69.Name = "sequenceActivity69";
            // 
            // sequenceActivity68
            // 
            this.sequenceActivity68.Activities.Add(this.logToHistoryListActivity94);
            this.sequenceActivity68.Activities.Add(this.onAdHocUser2ReviewTaskCreated);
            this.sequenceActivity68.Name = "sequenceActivity68";
            // 
            // onAdHocUser2ReviewTaskChanged
            // 
            activitybind147.Name = "BoardAgendaWorkflow";
            activitybind147.Path = "onAdHocUser2ReviewTaskChanged_AfterProperties";
            activitybind148.Name = "BoardAgendaWorkflow";
            activitybind148.Path = "onAdHocUser2ReviewTaskChanged_BeforeProperties";
            correlationtoken66.Name = "adHocUser2ReviewTask";
            correlationtoken66.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser2ReviewTaskChanged.CorrelationToken = correlationtoken66;
            this.onAdHocUser2ReviewTaskChanged.Executor = null;
            this.onAdHocUser2ReviewTaskChanged.Name = "onAdHocUser2ReviewTaskChanged";
            activitybind149.Name = "BoardAgendaWorkflow";
            activitybind149.Path = "adHocUser2ReviewTask_TaskId";
            this.onAdHocUser2ReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser2ReviewTaskChanged_Invoked);
            this.onAdHocUser2ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind148)));
            this.onAdHocUser2ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind149)));
            this.onAdHocUser2ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind147)));
            ruleconditionreference23.ConditionName = "Adhoc User1 Task Created BUT Not Completed";
            // 
            // sequenceActivity67
            // 
            this.sequenceActivity67.Activities.Add(this.ifElseActivity11);
            this.sequenceActivity67.Name = "sequenceActivity67";
            this.sequenceActivity67.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference23);
            // 
            // sequenceActivity66
            // 
            this.sequenceActivity66.Name = "sequenceActivity66";
            // 
            // sequenceActivity65
            // 
            this.sequenceActivity65.Activities.Add(this.logToHistoryListActivity85);
            this.sequenceActivity65.Activities.Add(this.onAdhocUser1TaskCreated);
            this.sequenceActivity65.Name = "sequenceActivity65";
            // 
            // onAdHocUser1ReviewTaskChanged
            // 
            activitybind150.Name = "BoardAgendaWorkflow";
            activitybind150.Path = "onAdHocUser1ReviewTaskChanged_AfterProperties";
            activitybind151.Name = "BoardAgendaWorkflow";
            activitybind151.Path = "onAdHocUser1ReviewTaskChanged_BeforeProperties";
            correlationtoken67.Name = "adHocUser1ReviewTask";
            correlationtoken67.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAdHocUser1ReviewTaskChanged.CorrelationToken = correlationtoken67;
            this.onAdHocUser1ReviewTaskChanged.Executor = null;
            this.onAdHocUser1ReviewTaskChanged.Name = "onAdHocUser1ReviewTaskChanged";
            activitybind152.Name = "BoardAgendaWorkflow";
            activitybind152.Path = "adHocUser1ReviewTask_TaskId";
            this.onAdHocUser1ReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAdhocUser1ReviewTaskChanged_Invoked);
            this.onAdHocUser1ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind151)));
            this.onAdHocUser1ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind152)));
            this.onAdHocUser1ReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind150)));
            ruleconditionreference24.ConditionName = "AGM Police Review Task is Created BUT not completed";
            // 
            // sequenceActivity64
            // 
            this.sequenceActivity64.Activities.Add(this.ifElseActivity10);
            this.sequenceActivity64.Name = "sequenceActivity64";
            this.sequenceActivity64.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference24);
            // 
            // sequenceActivity63
            // 
            this.sequenceActivity63.Name = "sequenceActivity63";
            // 
            // sequenceActivity62
            // 
            this.sequenceActivity62.Activities.Add(this.logToHistoryListActivity76);
            this.sequenceActivity62.Activities.Add(this.onAGMPoliceTaskCreated);
            this.sequenceActivity62.Name = "sequenceActivity62";
            // 
            // onAGMPoliceReviewTaskChanged
            // 
            activitybind153.Name = "BoardAgendaWorkflow";
            activitybind153.Path = "onAGMPoliceReviewTaskChanged_AfterProperties";
            activitybind154.Name = "BoardAgendaWorkflow";
            activitybind154.Path = "onAGMPoliceReviewTaskChanged_BeforeProperties";
            correlationtoken68.Name = "agmPoliceReviewTask";
            correlationtoken68.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMPoliceReviewTaskChanged.CorrelationToken = correlationtoken68;
            this.onAGMPoliceReviewTaskChanged.Executor = null;
            this.onAGMPoliceReviewTaskChanged.Name = "onAGMPoliceReviewTaskChanged";
            activitybind155.Name = "BoardAgendaWorkflow";
            activitybind155.Path = "agmPoliceReviewTask_TaskId";
            this.onAGMPoliceReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPoliceReviewTaskChanged_Invoked);
            this.onAGMPoliceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind154)));
            this.onAGMPoliceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind155)));
            this.onAGMPoliceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind153)));
            ruleconditionreference25.ConditionName = "AGMCommunications Task IS Created but NOT Completed";
            // 
            // sequenceActivity61
            // 
            this.sequenceActivity61.Activities.Add(this.ifElseActivity8);
            this.sequenceActivity61.Name = "sequenceActivity61";
            this.sequenceActivity61.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference25);
            // 
            // sequenceActivity60
            // 
            this.sequenceActivity60.Name = "sequenceActivity60";
            // 
            // sequenceActivity59
            // 
            this.sequenceActivity59.Activities.Add(this.logToHistoryListActivity67);
            this.sequenceActivity59.Activities.Add(this.onAGMCommunicationsReviewTaskCreated);
            this.sequenceActivity59.Name = "sequenceActivity59";
            // 
            // onAGMCommunicationsReviewTaskChanged
            // 
            activitybind156.Name = "BoardAgendaWorkflow";
            activitybind156.Path = "onAGMCommunicationsReviewTaskChanged_AfterProperties";
            activitybind157.Name = "BoardAgendaWorkflow";
            activitybind157.Path = "onAGMCommunicationsReviewTaskChanged_BeforeProperties";
            correlationtoken69.Name = "agmCommunicationsReviewTask";
            correlationtoken69.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMCommunicationsReviewTaskChanged.CorrelationToken = correlationtoken69;
            this.onAGMCommunicationsReviewTaskChanged.Executor = null;
            this.onAGMCommunicationsReviewTaskChanged.Name = "onAGMCommunicationsReviewTaskChanged";
            activitybind158.Name = "BoardAgendaWorkflow";
            activitybind158.Path = "agmCommunicationsReviewTask_TaskId";
            this.onAGMCommunicationsReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMCommunicationsReviewTaskChanged_Invoked);
            this.onAGMCommunicationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind157)));
            this.onAGMCommunicationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind158)));
            this.onAGMCommunicationsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind156)));
            ruleconditionreference26.ConditionName = "AGMAudit Task Created but AGMAudit Task NOT Completed";
            // 
            // sequenceActivity58
            // 
            this.sequenceActivity58.Activities.Add(this.ifElseActivity9);
            this.sequenceActivity58.Name = "sequenceActivity58";
            this.sequenceActivity58.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference26);
            // 
            // sequenceActivity57
            // 
            this.sequenceActivity57.Name = "sequenceActivity57";
            // 
            // sequenceActivity56
            // 
            this.sequenceActivity56.Activities.Add(this.logToHistoryListActivity58);
            this.sequenceActivity56.Activities.Add(this.onAGMAuditReviewTaskCreated);
            this.sequenceActivity56.Name = "sequenceActivity56";
            // 
            // onAGMAuditReviewTaskChanged
            // 
            activitybind159.Name = "BoardAgendaWorkflow";
            activitybind159.Path = "onAGMAuditReviewTaskChanged_AfterProperties";
            activitybind160.Name = "BoardAgendaWorkflow";
            activitybind160.Path = "onAGMAuditReviewTaskChanged_BeforeProperties";
            correlationtoken70.Name = "agmAuditReviewTask";
            correlationtoken70.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMAuditReviewTaskChanged.CorrelationToken = correlationtoken70;
            this.onAGMAuditReviewTaskChanged.Executor = null;
            this.onAGMAuditReviewTaskChanged.Name = "onAGMAuditReviewTaskChanged";
            activitybind161.Name = "BoardAgendaWorkflow";
            activitybind161.Path = "agmAuditReviewTask_TaskId";
            this.onAGMAuditReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMAuditReviewTaskChanged_Invoked);
            this.onAGMAuditReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind160)));
            this.onAGMAuditReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind161)));
            this.onAGMAuditReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind159)));
            ruleconditionreference27.ConditionName = "AGMContracts Task Created But not Completed";
            // 
            // sequenceActivity55
            // 
            this.sequenceActivity55.Activities.Add(this.ifElseActivity6);
            this.sequenceActivity55.Name = "sequenceActivity55";
            this.sequenceActivity55.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference27);
            // 
            // sequenceActivity54
            // 
            this.sequenceActivity54.Name = "sequenceActivity54";
            // 
            // sequenceActivity53
            // 
            this.sequenceActivity53.Activities.Add(this.logToHistoryListActivity49);
            this.sequenceActivity53.Activities.Add(this.onAGMContractsReviewTaskCreated);
            this.sequenceActivity53.Name = "sequenceActivity53";
            // 
            // onAGMContractsReviewTaskChanged
            // 
            activitybind162.Name = "BoardAgendaWorkflow";
            activitybind162.Path = "onAGMContractsReviewTaskChanged_AfterProperties";
            activitybind163.Name = "BoardAgendaWorkflow";
            activitybind163.Path = "onAGMContractsReviewTaskChanged_BeforeProperties";
            correlationtoken71.Name = "agmContractsReviewTask";
            correlationtoken71.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMContractsReviewTaskChanged.CorrelationToken = correlationtoken71;
            this.onAGMContractsReviewTaskChanged.Executor = null;
            this.onAGMContractsReviewTaskChanged.Name = "onAGMContractsReviewTaskChanged";
            activitybind164.Name = "BoardAgendaWorkflow";
            activitybind164.Path = "agmContractsReviewTask_TaskId";
            this.onAGMContractsReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMContractsReviewTaskChanged_Invoked);
            this.onAGMContractsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind163)));
            this.onAGMContractsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind164)));
            this.onAGMContractsReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind162)));
            ruleconditionreference28.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // sequenceActivity52
            // 
            this.sequenceActivity52.Activities.Add(this.ifElseActivity7);
            this.sequenceActivity52.Name = "sequenceActivity52";
            this.sequenceActivity52.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference28);
            // 
            // sequenceActivity51
            // 
            this.sequenceActivity51.Name = "sequenceActivity51";
            // 
            // sequenceActivity50
            // 
            this.sequenceActivity50.Activities.Add(this.logToHistoryListActivity40);
            this.sequenceActivity50.Activities.Add(this.onAGMLegalReviewTaskCompleted);
            this.sequenceActivity50.Name = "sequenceActivity50";
            // 
            // onAGMLegalReviewTaskChanged
            // 
            activitybind165.Name = "BoardAgendaWorkflow";
            activitybind165.Path = "onAGMLegalReviewTaskChanged_AfterProperties";
            activitybind166.Name = "BoardAgendaWorkflow";
            activitybind166.Path = "onAGMLegalReviewTaskChanged_BeforeProperties";
            correlationtoken72.Name = "agmLegalReviewTask";
            correlationtoken72.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMLegalReviewTaskChanged.CorrelationToken = correlationtoken72;
            this.onAGMLegalReviewTaskChanged.Executor = null;
            this.onAGMLegalReviewTaskChanged.Name = "onAGMLegalReviewTaskChanged";
            activitybind167.Name = "BoardAgendaWorkflow";
            activitybind167.Path = "agmLegalReviewTask_TaskId";
            this.onAGMLegalReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMLegalReviewTaskChanged_Invoked);
            this.onAGMLegalReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind166)));
            this.onAGMLegalReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind167)));
            this.onAGMLegalReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind165)));
            ruleconditionreference29.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // sequenceActivity49
            // 
            this.sequenceActivity49.Activities.Add(this.ifElseActivity4);
            this.sequenceActivity49.Name = "sequenceActivity49";
            this.sequenceActivity49.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference29);
            // 
            // sequenceActivity48
            // 
            this.sequenceActivity48.Name = "sequenceActivity48";
            // 
            // sequenceActivity47
            // 
            this.sequenceActivity47.Activities.Add(this.logToHistoryListActivity31);
            this.sequenceActivity47.Activities.Add(this.onAGMSafetyReviewTaskCreated);
            this.sequenceActivity47.Name = "sequenceActivity47";
            // 
            // onAGMSafetyReviewTaskChanged
            // 
            activitybind168.Name = "BoardAgendaWorkflow";
            activitybind168.Path = "onAGMSafetyReviewTaskChanged_AfterProperties";
            activitybind169.Name = "BoardAgendaWorkflow";
            activitybind169.Path = "onAGMSafetyReviewTaskChanged_BeforeProperties";
            correlationtoken73.Name = "agmSafetyReviewTask";
            correlationtoken73.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMSafetyReviewTaskChanged.CorrelationToken = correlationtoken73;
            this.onAGMSafetyReviewTaskChanged.Executor = null;
            this.onAGMSafetyReviewTaskChanged.Name = "onAGMSafetyReviewTaskChanged";
            activitybind170.Name = "BoardAgendaWorkflow";
            activitybind170.Path = "agmSafetyReviewTask_TaskId";
            this.onAGMSafetyReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMSafetyReviewTaskChanged_Invoked);
            this.onAGMSafetyReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind169)));
            this.onAGMSafetyReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind170)));
            this.onAGMSafetyReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind168)));
            ruleconditionreference30.ConditionName = "AGM Human Resources Task is created BUT not completed";
            // 
            // sequenceActivity46
            // 
            this.sequenceActivity46.Activities.Add(this.ifElseActivity5);
            this.sequenceActivity46.Name = "sequenceActivity46";
            this.sequenceActivity46.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference30);
            // 
            // sequenceActivity45
            // 
            this.sequenceActivity45.Name = "sequenceActivity45";
            // 
            // sequenceActivity44
            // 
            this.sequenceActivity44.Activities.Add(this.logToHistoryListActivity22);
            this.sequenceActivity44.Activities.Add(this.onAGMHumanResourcesReviewTaskCreated);
            this.sequenceActivity44.Name = "sequenceActivity44";
            // 
            // onAGMHumanResourcesReviewTaskChanged
            // 
            activitybind171.Name = "BoardAgendaWorkflow";
            activitybind171.Path = "onAGMHumanResourcesReviewTaskChanged_AfterProperties";
            activitybind172.Name = "BoardAgendaWorkflow";
            activitybind172.Path = "onAGMHumanResourcesReviewTaskChanged_BeforeProperties";
            correlationtoken74.Name = "agmHumanResourcesReviewTask";
            correlationtoken74.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMHumanResourcesReviewTaskChanged.CorrelationToken = correlationtoken74;
            this.onAGMHumanResourcesReviewTaskChanged.Executor = null;
            this.onAGMHumanResourcesReviewTaskChanged.Name = "onAGMHumanResourcesReviewTaskChanged";
            activitybind173.Name = "BoardAgendaWorkflow";
            activitybind173.Path = "agmHumanResourcesReviewTask_TaskId";
            this.onAGMHumanResourcesReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMHumanResourcesReviewTaskChanged_Invoked);
            this.onAGMHumanResourcesReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind172)));
            this.onAGMHumanResourcesReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind173)));
            this.onAGMHumanResourcesReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind171)));
            ruleconditionreference31.ConditionName = "AGM Planning Task is Created BUT AGM Planning Task is not Completed";
            // 
            // sequenceActivity43
            // 
            this.sequenceActivity43.Activities.Add(this.ifElseActivity3);
            this.sequenceActivity43.Name = "sequenceActivity43";
            this.sequenceActivity43.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference31);
            // 
            // sequenceActivity42
            // 
            this.sequenceActivity42.Name = "sequenceActivity42";
            // 
            // sequenceActivity41
            // 
            this.sequenceActivity41.Activities.Add(this.logToHistoryListActivity13);
            this.sequenceActivity41.Activities.Add(this.onAGMPlanningReviewTaskCreated);
            this.sequenceActivity41.Name = "sequenceActivity41";
            // 
            // onAGMPlanningTaskChanged
            // 
            activitybind174.Name = "BoardAgendaWorkflow";
            activitybind174.Path = "onAGMPlanningTaskChanged_AfterProperties";
            activitybind175.Name = "BoardAgendaWorkflow";
            activitybind175.Path = "onAGMPlanningTaskChanged_BeforeProperties";
            correlationtoken75.Name = "agmPlanningReviewTask";
            correlationtoken75.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMPlanningTaskChanged.CorrelationToken = correlationtoken75;
            this.onAGMPlanningTaskChanged.Executor = null;
            this.onAGMPlanningTaskChanged.Name = "onAGMPlanningTaskChanged";
            activitybind176.Name = "BoardAgendaWorkflow";
            activitybind176.Path = "agmPlanningReviewTask_TaskId";
            this.onAGMPlanningTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMPlanningReviewTaskChanged_Invoked);
            this.onAGMPlanningTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind175)));
            this.onAGMPlanningTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind176)));
            this.onAGMPlanningTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind174)));
            ruleconditionreference32.ConditionName = "AGM IT Task Created but AGMIT Task NOT Completed";
            // 
            // sequenceActivity40
            // 
            this.sequenceActivity40.Activities.Add(this.ifElseActivity2);
            this.sequenceActivity40.Name = "sequenceActivity40";
            this.sequenceActivity40.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference32);
            // 
            // sequenceActivity39
            // 
            this.sequenceActivity39.Name = "sequenceActivity39";
            // 
            // sequenceActivity38
            // 
            this.sequenceActivity38.Activities.Add(this.logToHistoryListActivity4);
            this.sequenceActivity38.Activities.Add(this.onAGMITReviewTaskCreated);
            this.sequenceActivity38.Name = "sequenceActivity38";
            // 
            // onAGMITReviewTaskChanged
            // 
            activitybind177.Name = "BoardAgendaWorkflow";
            activitybind177.Path = "onAGMITReviewTaskChanged_AfterProperties";
            activitybind178.Name = "BoardAgendaWorkflow";
            activitybind178.Path = "onAGMITReviewTaskChanged_BeforeProperties";
            correlationtoken76.Name = "agmITReviewTask";
            correlationtoken76.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMITReviewTaskChanged.CorrelationToken = correlationtoken76;
            this.onAGMITReviewTaskChanged.Executor = null;
            this.onAGMITReviewTaskChanged.Name = "onAGMITReviewTaskChanged";
            activitybind179.Name = "BoardAgendaWorkflow";
            activitybind179.Path = "agmITReviewTask_TaskId";
            this.onAGMITReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMITReviewTaskChanged_Invoked);
            this.onAGMITReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind178)));
            this.onAGMITReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind179)));
            this.onAGMITReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind177)));
            ruleconditionreference33.ConditionName = "AGMFinanceTask Created BUT AGMFinanceTask NOT Completed";
            // 
            // agmFinanceReviewDueDateMonitorSequence
            // 
            this.agmFinanceReviewDueDateMonitorSequence.Activities.Add(this.ifAGMReviewTaskOverdue);
            this.agmFinanceReviewDueDateMonitorSequence.Name = "agmFinanceReviewDueDateMonitorSequence";
            this.agmFinanceReviewDueDateMonitorSequence.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference33);
            // 
            // agmReviewTaskCompletedSequence
            // 
            this.agmReviewTaskCompletedSequence.Name = "agmReviewTaskCompletedSequence";
            // 
            // agmReviewTaskCreatedSequence
            // 
            this.agmReviewTaskCreatedSequence.Activities.Add(this.logAGMFinanceReviewTaskCreatedInSequence);
            this.agmReviewTaskCreatedSequence.Activities.Add(this.onAGMFinanceReviewTaskCreated);
            this.agmReviewTaskCreatedSequence.Name = "agmReviewTaskCreatedSequence";
            // 
            // onAGMFinanceReviewTaskChanged
            // 
            activitybind180.Name = "BoardAgendaWorkflow";
            activitybind180.Path = "onAGMFinanceReviewTaskChanged_AfterProperties";
            activitybind181.Name = "BoardAgendaWorkflow";
            activitybind181.Path = "onAGMFinanceReviewTaskChanged_BeforeProperties";
            correlationtoken77.Name = "agmFinanceReviewTask";
            correlationtoken77.OwnerActivityName = "BoardAgendaWorkflow";
            this.onAGMFinanceReviewTaskChanged.CorrelationToken = correlationtoken77;
            this.onAGMFinanceReviewTaskChanged.Executor = null;
            this.onAGMFinanceReviewTaskChanged.Name = "onAGMFinanceReviewTaskChanged";
            activitybind182.Name = "BoardAgendaWorkflow";
            activitybind182.Path = "agmFinanceReviewTask_TaskId";
            this.onAGMFinanceReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMFinanceReviewTaskChanged_Invoked);
            this.onAGMFinanceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind181)));
            this.onAGMFinanceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind182)));
            this.onAGMFinanceReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind180)));
            // 
            // sequenceActivity93
            // 
            this.sequenceActivity93.Activities.Add(this.ifElseExecutiveDirectorSelected);
            this.sequenceActivity93.Name = "sequenceActivity93";
            // 
            // ifElseAGMRailOperationsSelected
            // 
            this.ifElseAGMRailOperationsSelected.Activities.Add(this.ifElseBranchActivity33);
            this.ifElseAGMRailOperationsSelected.Activities.Add(this.ifElseBranchActivity34);
            this.ifElseAGMRailOperationsSelected.Description = "IF AGM-RailOperations review is required for this document set";
            this.ifElseAGMRailOperationsSelected.Name = "ifElseAGMRailOperationsSelected";
            // 
            // ifElseAGMBusOperationsSelected
            // 
            this.ifElseAGMBusOperationsSelected.Activities.Add(this.ifElseBranchActivity29);
            this.ifElseAGMBusOperationsSelected.Activities.Add(this.ifElseBranchActivity30);
            this.ifElseAGMBusOperationsSelected.Description = "IF AGM-Bus Operations review is required for this document set";
            this.ifElseAGMBusOperationsSelected.Name = "ifElseAGMBusOperationsSelected";
            // 
            // ifElseAdHocUser4Selected
            // 
            this.ifElseAdHocUser4Selected.Activities.Add(this.ifElseBranchActivity27);
            this.ifElseAdHocUser4Selected.Activities.Add(this.ifElseBranchActivity28);
            this.ifElseAdHocUser4Selected.Description = "IF AdHoc User4 review is required for this document set";
            this.ifElseAdHocUser4Selected.Name = "ifElseAdHocUser4Selected";
            // 
            // logToHistoryListActivity102
            // 
            this.logToHistoryListActivity102.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity102.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity102.HistoryDescription = "AdHoc User3 was NOT selected";
            this.logToHistoryListActivity102.HistoryOutcome = "";
            this.logToHistoryListActivity102.Name = "logToHistoryListActivity102";
            this.logToHistoryListActivity102.OtherData = "";
            this.logToHistoryListActivity102.UserId = -1;
            // 
            // CAGforAdHocUser3ReviewTask
            // 
            this.CAGforAdHocUser3ReviewTask.Activities.Add(this.sequenceActivity71);
            this.CAGforAdHocUser3ReviewTask.Activities.Add(this.sequenceActivity72);
            this.CAGforAdHocUser3ReviewTask.Activities.Add(this.sequenceActivity73);
            this.CAGforAdHocUser3ReviewTask.Enabled = false;
            this.CAGforAdHocUser3ReviewTask.Name = "CAGforAdHocUser3ReviewTask";
            ruleconditionreference34.ConditionName = "Adhoc User3 Review Task IS complete";
            this.CAGforAdHocUser3ReviewTask.UntilCondition = ruleconditionreference34;
            // 
            // logToHistoryListActivity104
            // 
            this.logToHistoryListActivity104.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity104.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity104.HistoryDescription = "AdHocUser3 Review Task Completed";
            this.logToHistoryListActivity104.HistoryOutcome = "";
            this.logToHistoryListActivity104.Name = "logToHistoryListActivity104";
            this.logToHistoryListActivity104.OtherData = "";
            this.logToHistoryListActivity104.UserId = -1;
            // 
            // adHocUser3ReviewTaskCompleted
            // 
            correlationtoken78.Name = "adHocUser3ReviewTask";
            correlationtoken78.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser3ReviewTaskCompleted.CorrelationToken = correlationtoken78;
            this.adHocUser3ReviewTaskCompleted.Name = "adHocUser3ReviewTaskCompleted";
            activitybind183.Name = "BoardAgendaWorkflow";
            activitybind183.Path = "adHocUser3ReviewTask_TaskId";
            this.adHocUser3ReviewTaskCompleted.TaskOutcome = null;
            this.adHocUser3ReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind183)));
            // 
            // whileAdHocUser3ReviewTaskIsNOTComplete
            // 
            this.whileAdHocUser3ReviewTaskIsNOTComplete.Activities.Add(this.onAdHocUser3TaskChanged);
            ruleconditionreference35.ConditionName = "Check if Adhoc User3 Review task is Complete";
            this.whileAdHocUser3ReviewTaskIsNOTComplete.Condition = ruleconditionreference35;
            this.whileAdHocUser3ReviewTaskIsNOTComplete.Name = "whileAdHocUser3ReviewTaskIsNOTComplete";
            // 
            // logToHistoryListActivity101
            // 
            this.logToHistoryListActivity101.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity101.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity101.HistoryDescription = "Adhoc User3 Review TASK created";
            this.logToHistoryListActivity101.HistoryOutcome = "";
            this.logToHistoryListActivity101.Name = "logToHistoryListActivity101";
            this.logToHistoryListActivity101.OtherData = "";
            this.logToHistoryListActivity101.UserId = -1;
            // 
            // adHocUser3ReviewTask
            // 
            this.adHocUser3ReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken79.Name = "adHocUser3ReviewTask";
            correlationtoken79.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser3ReviewTask.CorrelationToken = correlationtoken79;
            this.adHocUser3ReviewTask.ListItemId = -1;
            this.adHocUser3ReviewTask.Name = "adHocUser3ReviewTask";
            this.adHocUser3ReviewTask.SpecialPermissions = null;
            activitybind184.Name = "BoardAgendaWorkflow";
            activitybind184.Path = "adHocUser3ReviewTask_TaskId";
            activitybind185.Name = "BoardAgendaWorkflow";
            activitybind185.Path = "adHocUser3ReviewTask_TaskProperties";
            this.adHocUser3ReviewTask.MethodInvoking += new System.EventHandler(this.adhocUser3ReviewTask_MethodInvoking);
            this.adHocUser3ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind185)));
            this.adHocUser3ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind184)));
            // 
            // logToHistoryListActivity100
            // 
            this.logToHistoryListActivity100.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity100.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity100.HistoryDescription = "Creating AdhocUser3 Review Task";
            this.logToHistoryListActivity100.HistoryOutcome = "";
            this.logToHistoryListActivity100.Name = "logToHistoryListActivity100";
            this.logToHistoryListActivity100.OtherData = "";
            this.logToHistoryListActivity100.UserId = -1;
            // 
            // logToHistoryListActivity93
            // 
            this.logToHistoryListActivity93.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity93.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity93.HistoryDescription = "AdHoc User2 was NOT selected";
            this.logToHistoryListActivity93.HistoryOutcome = "";
            this.logToHistoryListActivity93.Name = "logToHistoryListActivity93";
            this.logToHistoryListActivity93.OtherData = "";
            this.logToHistoryListActivity93.UserId = -1;
            // 
            // CAGforAdHocUser2ReviewTask
            // 
            this.CAGforAdHocUser2ReviewTask.Activities.Add(this.sequenceActivity68);
            this.CAGforAdHocUser2ReviewTask.Activities.Add(this.sequenceActivity69);
            this.CAGforAdHocUser2ReviewTask.Activities.Add(this.sequenceActivity70);
            this.CAGforAdHocUser2ReviewTask.Enabled = false;
            this.CAGforAdHocUser2ReviewTask.Name = "CAGforAdHocUser2ReviewTask";
            ruleconditionreference36.ConditionName = "Adhoc User2 Review Task IS Complete";
            this.CAGforAdHocUser2ReviewTask.UntilCondition = ruleconditionreference36;
            // 
            // logToHistoryListActivity95
            // 
            this.logToHistoryListActivity95.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity95.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity95.HistoryDescription = "AdHocUser2 Review Task Completed";
            this.logToHistoryListActivity95.HistoryOutcome = "";
            this.logToHistoryListActivity95.Name = "logToHistoryListActivity95";
            this.logToHistoryListActivity95.OtherData = "";
            this.logToHistoryListActivity95.UserId = -1;
            // 
            // adHocUser2ReviewTaskCompleted
            // 
            correlationtoken80.Name = "adHocUser2ReviewTask";
            correlationtoken80.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser2ReviewTaskCompleted.CorrelationToken = correlationtoken80;
            this.adHocUser2ReviewTaskCompleted.Name = "adHocUser2ReviewTaskCompleted";
            activitybind186.Name = "BoardAgendaWorkflow";
            activitybind186.Path = "adHocUser2ReviewTask_TaskId";
            this.adHocUser2ReviewTaskCompleted.TaskOutcome = null;
            this.adHocUser2ReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind186)));
            // 
            // whileAdHocUser2ReviewTaskNOTComplete
            // 
            this.whileAdHocUser2ReviewTaskNOTComplete.Activities.Add(this.onAdHocUser2ReviewTaskChanged);
            ruleconditionreference37.ConditionName = "Check if Adhoc User2 Review Task is Complete";
            this.whileAdHocUser2ReviewTaskNOTComplete.Condition = ruleconditionreference37;
            this.whileAdHocUser2ReviewTaskNOTComplete.Name = "whileAdHocUser2ReviewTaskNOTComplete";
            // 
            // logToHistoryListActivity92
            // 
            this.logToHistoryListActivity92.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity92.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity92.HistoryDescription = "Adhoc User2 Review TASK created";
            this.logToHistoryListActivity92.HistoryOutcome = "";
            this.logToHistoryListActivity92.Name = "logToHistoryListActivity92";
            this.logToHistoryListActivity92.OtherData = "";
            this.logToHistoryListActivity92.UserId = -1;
            // 
            // adHocUser2ReviewTask
            // 
            this.adHocUser2ReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken81.Name = "adHocUser2ReviewTask";
            correlationtoken81.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser2ReviewTask.CorrelationToken = correlationtoken81;
            this.adHocUser2ReviewTask.ListItemId = -1;
            this.adHocUser2ReviewTask.Name = "adHocUser2ReviewTask";
            this.adHocUser2ReviewTask.SpecialPermissions = null;
            activitybind187.Name = "BoardAgendaWorkflow";
            activitybind187.Path = "adHocUser2ReviewTask_TaskId";
            activitybind188.Name = "BoardAgendaWorkflow";
            activitybind188.Path = "adHocUser2ReviewTask_TaskProperties";
            this.adHocUser2ReviewTask.MethodInvoking += new System.EventHandler(this.adhocUser2ReviewTask_MethodInvoking);
            this.adHocUser2ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind188)));
            this.adHocUser2ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind187)));
            // 
            // logToHistoryListActivity91
            // 
            this.logToHistoryListActivity91.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity91.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity91.HistoryDescription = "Creating AdhocUser2 Review Task";
            this.logToHistoryListActivity91.HistoryOutcome = "";
            this.logToHistoryListActivity91.Name = "logToHistoryListActivity91";
            this.logToHistoryListActivity91.OtherData = "";
            this.logToHistoryListActivity91.UserId = -1;
            // 
            // logToHistoryListActivity84
            // 
            this.logToHistoryListActivity84.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity84.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity84.HistoryDescription = "AdHoc User1 was NOT selected";
            this.logToHistoryListActivity84.HistoryOutcome = "";
            this.logToHistoryListActivity84.Name = "logToHistoryListActivity84";
            this.logToHistoryListActivity84.OtherData = "";
            this.logToHistoryListActivity84.UserId = -1;
            // 
            // CAGforAdHocUser1ReviewTask
            // 
            this.CAGforAdHocUser1ReviewTask.Activities.Add(this.sequenceActivity65);
            this.CAGforAdHocUser1ReviewTask.Activities.Add(this.sequenceActivity66);
            this.CAGforAdHocUser1ReviewTask.Activities.Add(this.sequenceActivity67);
            this.CAGforAdHocUser1ReviewTask.Enabled = false;
            this.CAGforAdHocUser1ReviewTask.Name = "CAGforAdHocUser1ReviewTask";
            ruleconditionreference38.ConditionName = "Adhoc User1 Review Task IS complete";
            this.CAGforAdHocUser1ReviewTask.UntilCondition = ruleconditionreference38;
            // 
            // logToHistoryListActivity86
            // 
            this.logToHistoryListActivity86.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity86.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity86.HistoryDescription = "AdHocUser1 Review Task Completed";
            this.logToHistoryListActivity86.HistoryOutcome = "";
            this.logToHistoryListActivity86.Name = "logToHistoryListActivity86";
            this.logToHistoryListActivity86.OtherData = "";
            this.logToHistoryListActivity86.UserId = -1;
            // 
            // adHocUser1ReviewTaskCompleted
            // 
            correlationtoken82.Name = "adHocUser1ReviewTask";
            correlationtoken82.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser1ReviewTaskCompleted.CorrelationToken = correlationtoken82;
            this.adHocUser1ReviewTaskCompleted.Name = "adHocUser1ReviewTaskCompleted";
            activitybind189.Name = "BoardAgendaWorkflow";
            activitybind189.Path = "adHocUser1ReviewTask_TaskId";
            this.adHocUser1ReviewTaskCompleted.TaskOutcome = null;
            this.adHocUser1ReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind189)));
            // 
            // whileAdhocUser1ReviewTaskIsNotComplete
            // 
            this.whileAdhocUser1ReviewTaskIsNotComplete.Activities.Add(this.onAdHocUser1ReviewTaskChanged);
            ruleconditionreference39.ConditionName = "Check if Adhoc User1 Review Task is Complete";
            this.whileAdhocUser1ReviewTaskIsNotComplete.Condition = ruleconditionreference39;
            this.whileAdhocUser1ReviewTaskIsNotComplete.Name = "whileAdhocUser1ReviewTaskIsNotComplete";
            // 
            // logToHistoryListActivity83
            // 
            this.logToHistoryListActivity83.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity83.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity83.HistoryDescription = "Adhoc Review TASK created";
            this.logToHistoryListActivity83.HistoryOutcome = "";
            this.logToHistoryListActivity83.Name = "logToHistoryListActivity83";
            this.logToHistoryListActivity83.OtherData = "";
            this.logToHistoryListActivity83.UserId = -1;
            // 
            // adHocUser1ReviewTask
            // 
            this.adHocUser1ReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken83.Name = "adHocUser1ReviewTask";
            correlationtoken83.OwnerActivityName = "BoardAgendaWorkflow";
            this.adHocUser1ReviewTask.CorrelationToken = correlationtoken83;
            this.adHocUser1ReviewTask.ListItemId = -1;
            this.adHocUser1ReviewTask.Name = "adHocUser1ReviewTask";
            this.adHocUser1ReviewTask.SpecialPermissions = null;
            activitybind190.Name = "BoardAgendaWorkflow";
            activitybind190.Path = "adHocUser1ReviewTask_TaskId";
            activitybind191.Name = "BoardAgendaWorkflow";
            activitybind191.Path = "adHocUser1ReviewTask_TaskProperties";
            this.adHocUser1ReviewTask.MethodInvoking += new System.EventHandler(this.adhocUser1ReviewTask_MethodInvoking);
            this.adHocUser1ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind191)));
            this.adHocUser1ReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind190)));
            // 
            // logToHistoryListActivity82
            // 
            this.logToHistoryListActivity82.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity82.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity82.HistoryDescription = "Creating AdhocUser1 Review Task";
            this.logToHistoryListActivity82.HistoryOutcome = "";
            this.logToHistoryListActivity82.Name = "logToHistoryListActivity82";
            this.logToHistoryListActivity82.OtherData = "";
            this.logToHistoryListActivity82.UserId = -1;
            // 
            // logToHistoryListActivity75
            // 
            this.logToHistoryListActivity75.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity75.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity75.HistoryDescription = "AGM Police was NOT selected";
            this.logToHistoryListActivity75.HistoryOutcome = "";
            this.logToHistoryListActivity75.Name = "logToHistoryListActivity75";
            this.logToHistoryListActivity75.OtherData = "";
            this.logToHistoryListActivity75.UserId = -1;
            // 
            // CAGforAGMPoliceReviewTask
            // 
            this.CAGforAGMPoliceReviewTask.Activities.Add(this.sequenceActivity62);
            this.CAGforAGMPoliceReviewTask.Activities.Add(this.sequenceActivity63);
            this.CAGforAGMPoliceReviewTask.Activities.Add(this.sequenceActivity64);
            this.CAGforAGMPoliceReviewTask.Enabled = false;
            this.CAGforAGMPoliceReviewTask.Name = "CAGforAGMPoliceReviewTask";
            ruleconditionreference40.ConditionName = "AGM Police Review Task IS Complete";
            this.CAGforAGMPoliceReviewTask.UntilCondition = ruleconditionreference40;
            // 
            // logToHistoryListActivity77
            // 
            this.logToHistoryListActivity77.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity77.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity77.HistoryDescription = "AGM Police Review Task Completed";
            this.logToHistoryListActivity77.HistoryOutcome = "";
            this.logToHistoryListActivity77.Name = "logToHistoryListActivity77";
            this.logToHistoryListActivity77.OtherData = "";
            this.logToHistoryListActivity77.UserId = -1;
            // 
            // agmPoliceReviewTaskCompleted
            // 
            correlationtoken84.Name = "agmPoliceReviewTask";
            correlationtoken84.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPoliceReviewTaskCompleted.CorrelationToken = correlationtoken84;
            this.agmPoliceReviewTaskCompleted.Name = "agmPoliceReviewTaskCompleted";
            activitybind192.Name = "BoardAgendaWorkflow";
            activitybind192.Path = "agmPoliceReviewTask_TaskId";
            this.agmPoliceReviewTaskCompleted.TaskOutcome = null;
            this.agmPoliceReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind192)));
            // 
            // whileAGMPoliceReviewTaskIsNOTComplete
            // 
            this.whileAGMPoliceReviewTaskIsNOTComplete.Activities.Add(this.onAGMPoliceReviewTaskChanged);
            ruleconditionreference41.ConditionName = "Check if AGM_Police Review Task is complete";
            this.whileAGMPoliceReviewTaskIsNOTComplete.Condition = ruleconditionreference41;
            this.whileAGMPoliceReviewTaskIsNOTComplete.Name = "whileAGMPoliceReviewTaskIsNOTComplete";
            // 
            // logToHistoryListActivity74
            // 
            this.logToHistoryListActivity74.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity74.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity74.HistoryDescription = "AGM Police Review TASK created";
            this.logToHistoryListActivity74.HistoryOutcome = "";
            this.logToHistoryListActivity74.Name = "logToHistoryListActivity74";
            this.logToHistoryListActivity74.OtherData = "";
            this.logToHistoryListActivity74.UserId = -1;
            // 
            // sendEmailAGMPoliceAdmin
            // 
            this.sendEmailAGMPoliceAdmin.BCC = null;
            this.sendEmailAGMPoliceAdmin.Body = null;
            this.sendEmailAGMPoliceAdmin.CC = null;
            correlationtoken85.Name = "workflowToken";
            correlationtoken85.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMPoliceAdmin.CorrelationToken = correlationtoken85;
            this.sendEmailAGMPoliceAdmin.From = null;
            this.sendEmailAGMPoliceAdmin.Headers = null;
            this.sendEmailAGMPoliceAdmin.IncludeStatus = false;
            this.sendEmailAGMPoliceAdmin.Name = "sendEmailAGMPoliceAdmin";
            this.sendEmailAGMPoliceAdmin.Subject = null;
            this.sendEmailAGMPoliceAdmin.To = null;
            this.sendEmailAGMPoliceAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMPoliceAdmin_MethodInvoking);
            // 
            // agmPoliceReviewTask
            // 
            this.agmPoliceReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken86.Name = "agmPoliceReviewTask";
            correlationtoken86.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPoliceReviewTask.CorrelationToken = correlationtoken86;
            this.agmPoliceReviewTask.ListItemId = -1;
            this.agmPoliceReviewTask.Name = "agmPoliceReviewTask";
            this.agmPoliceReviewTask.SpecialPermissions = null;
            activitybind193.Name = "BoardAgendaWorkflow";
            activitybind193.Path = "agmPoliceReviewTask_TaskId";
            activitybind194.Name = "BoardAgendaWorkflow";
            activitybind194.Path = "agmPoliceReviewTask_TaskProperties";
            this.agmPoliceReviewTask.MethodInvoking += new System.EventHandler(this.agmPoliceReviewTask_MethodInvoking);
            this.agmPoliceReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind194)));
            this.agmPoliceReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind193)));
            // 
            // logToHistoryListActivity73
            // 
            this.logToHistoryListActivity73.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity73.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity73.HistoryDescription = "Creating AGM-Police Review Task";
            this.logToHistoryListActivity73.HistoryOutcome = "";
            this.logToHistoryListActivity73.Name = "logToHistoryListActivity73";
            this.logToHistoryListActivity73.OtherData = "";
            this.logToHistoryListActivity73.UserId = -1;
            // 
            // logToHistoryListActivity66
            // 
            this.logToHistoryListActivity66.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity66.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity66.HistoryDescription = "AGM Communications was NOT selected";
            this.logToHistoryListActivity66.HistoryOutcome = "";
            this.logToHistoryListActivity66.Name = "logToHistoryListActivity66";
            this.logToHistoryListActivity66.OtherData = "";
            this.logToHistoryListActivity66.UserId = -1;
            // 
            // CAGforAGMCommunicationsReviewTask
            // 
            this.CAGforAGMCommunicationsReviewTask.Activities.Add(this.sequenceActivity59);
            this.CAGforAGMCommunicationsReviewTask.Activities.Add(this.sequenceActivity60);
            this.CAGforAGMCommunicationsReviewTask.Activities.Add(this.sequenceActivity61);
            this.CAGforAGMCommunicationsReviewTask.Enabled = false;
            this.CAGforAGMCommunicationsReviewTask.Name = "CAGforAGMCommunicationsReviewTask";
            ruleconditionreference42.ConditionName = "AGM Communications Review Task IS completed";
            this.CAGforAGMCommunicationsReviewTask.UntilCondition = ruleconditionreference42;
            // 
            // logToHistoryListActivity68
            // 
            this.logToHistoryListActivity68.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity68.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity68.HistoryDescription = "AGM Communications Review Task Completed";
            this.logToHistoryListActivity68.HistoryOutcome = "";
            this.logToHistoryListActivity68.Name = "logToHistoryListActivity68";
            this.logToHistoryListActivity68.OtherData = "";
            this.logToHistoryListActivity68.UserId = -1;
            // 
            // agmCommunicationsTaskCompleted
            // 
            correlationtoken87.Name = "agmCommunicationsReviewTask";
            correlationtoken87.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmCommunicationsTaskCompleted.CorrelationToken = correlationtoken87;
            this.agmCommunicationsTaskCompleted.Name = "agmCommunicationsTaskCompleted";
            activitybind195.Name = "BoardAgendaWorkflow";
            activitybind195.Path = "agmCommunicationsReviewTask_TaskId";
            this.agmCommunicationsTaskCompleted.TaskOutcome = null;
            this.agmCommunicationsTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind195)));
            // 
            // whileAGMCommunicationsTaskIsNOTComplete
            // 
            this.whileAGMCommunicationsTaskIsNOTComplete.Activities.Add(this.onAGMCommunicationsReviewTaskChanged);
            ruleconditionreference43.ConditionName = "Check if AGM_Communications REview task is complete";
            this.whileAGMCommunicationsTaskIsNOTComplete.Condition = ruleconditionreference43;
            this.whileAGMCommunicationsTaskIsNOTComplete.Name = "whileAGMCommunicationsTaskIsNOTComplete";
            // 
            // logToHistoryListActivity65
            // 
            this.logToHistoryListActivity65.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity65.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity65.HistoryDescription = "AGM Communications Review TASK created";
            this.logToHistoryListActivity65.HistoryOutcome = "";
            this.logToHistoryListActivity65.Name = "logToHistoryListActivity65";
            this.logToHistoryListActivity65.OtherData = "";
            this.logToHistoryListActivity65.UserId = -1;
            // 
            // sendEmailAGMCommunicationsAdmin
            // 
            this.sendEmailAGMCommunicationsAdmin.BCC = null;
            this.sendEmailAGMCommunicationsAdmin.Body = null;
            this.sendEmailAGMCommunicationsAdmin.CC = null;
            correlationtoken88.Name = "workflowToken";
            correlationtoken88.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMCommunicationsAdmin.CorrelationToken = correlationtoken88;
            this.sendEmailAGMCommunicationsAdmin.From = null;
            this.sendEmailAGMCommunicationsAdmin.Headers = null;
            this.sendEmailAGMCommunicationsAdmin.IncludeStatus = false;
            this.sendEmailAGMCommunicationsAdmin.Name = "sendEmailAGMCommunicationsAdmin";
            this.sendEmailAGMCommunicationsAdmin.Subject = null;
            this.sendEmailAGMCommunicationsAdmin.To = null;
            this.sendEmailAGMCommunicationsAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMCommunicationsAdmin_MethodInvoking);
            // 
            // agmCommunicationsReviewTask
            // 
            this.agmCommunicationsReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken89.Name = "agmCommunicationsReviewTask";
            correlationtoken89.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmCommunicationsReviewTask.CorrelationToken = correlationtoken89;
            this.agmCommunicationsReviewTask.ListItemId = -1;
            this.agmCommunicationsReviewTask.Name = "agmCommunicationsReviewTask";
            this.agmCommunicationsReviewTask.SpecialPermissions = null;
            activitybind196.Name = "BoardAgendaWorkflow";
            activitybind196.Path = "agmCommunicationsReviewTask_TaskId";
            activitybind197.Name = "BoardAgendaWorkflow";
            activitybind197.Path = "agmCommunicationsReviewTask_TaskProperties";
            this.agmCommunicationsReviewTask.MethodInvoking += new System.EventHandler(this.agmCommunicationsReviewTask_MethodInvoking);
            this.agmCommunicationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind197)));
            this.agmCommunicationsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind196)));
            // 
            // logToHistoryListActivity64
            // 
            this.logToHistoryListActivity64.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity64.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity64.HistoryDescription = "Creating AGM-Communication Review Task";
            this.logToHistoryListActivity64.HistoryOutcome = "";
            this.logToHistoryListActivity64.Name = "logToHistoryListActivity64";
            this.logToHistoryListActivity64.OtherData = "";
            this.logToHistoryListActivity64.UserId = -1;
            // 
            // logToHistoryListActivity57
            // 
            this.logToHistoryListActivity57.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity57.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity57.HistoryDescription = "AGM Audit was NOT selected";
            this.logToHistoryListActivity57.HistoryOutcome = "";
            this.logToHistoryListActivity57.Name = "logToHistoryListActivity57";
            this.logToHistoryListActivity57.OtherData = "";
            this.logToHistoryListActivity57.UserId = -1;
            // 
            // CAGforAGMAuditReviewTask
            // 
            this.CAGforAGMAuditReviewTask.Activities.Add(this.sequenceActivity56);
            this.CAGforAGMAuditReviewTask.Activities.Add(this.sequenceActivity57);
            this.CAGforAGMAuditReviewTask.Activities.Add(this.sequenceActivity58);
            this.CAGforAGMAuditReviewTask.Enabled = false;
            this.CAGforAGMAuditReviewTask.Name = "CAGforAGMAuditReviewTask";
            ruleconditionreference44.ConditionName = "AGM Audit Review Task IS completed";
            this.CAGforAGMAuditReviewTask.UntilCondition = ruleconditionreference44;
            // 
            // logToHistoryListActivity59
            // 
            this.logToHistoryListActivity59.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity59.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity59.HistoryDescription = "AGM Audit Review Task Completed";
            this.logToHistoryListActivity59.HistoryOutcome = "";
            this.logToHistoryListActivity59.Name = "logToHistoryListActivity59";
            this.logToHistoryListActivity59.OtherData = "";
            this.logToHistoryListActivity59.UserId = -1;
            // 
            // agmAuditReviewTaskCompleted
            // 
            correlationtoken90.Name = "agmAuditReviewTask";
            correlationtoken90.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmAuditReviewTaskCompleted.CorrelationToken = correlationtoken90;
            this.agmAuditReviewTaskCompleted.Name = "agmAuditReviewTaskCompleted";
            activitybind198.Name = "BoardAgendaWorkflow";
            activitybind198.Path = "agmAuditReviewTask_TaskId";
            this.agmAuditReviewTaskCompleted.TaskOutcome = null;
            this.agmAuditReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind198)));
            // 
            // whileAGMAuditReviewTaskIsNotComplete
            // 
            this.whileAGMAuditReviewTaskIsNotComplete.Activities.Add(this.onAGMAuditReviewTaskChanged);
            ruleconditionreference45.ConditionName = "Check if AGM-Audit Review Task is complete";
            this.whileAGMAuditReviewTaskIsNotComplete.Condition = ruleconditionreference45;
            this.whileAGMAuditReviewTaskIsNotComplete.Name = "whileAGMAuditReviewTaskIsNotComplete";
            // 
            // logToHistoryListActivity56
            // 
            this.logToHistoryListActivity56.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity56.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity56.HistoryDescription = "AGM Audit Review TASK created";
            this.logToHistoryListActivity56.HistoryOutcome = "";
            this.logToHistoryListActivity56.Name = "logToHistoryListActivity56";
            this.logToHistoryListActivity56.OtherData = "";
            this.logToHistoryListActivity56.UserId = -1;
            // 
            // sendEmailAGMAudit
            // 
            this.sendEmailAGMAudit.BCC = null;
            this.sendEmailAGMAudit.Body = null;
            this.sendEmailAGMAudit.CC = null;
            correlationtoken91.Name = "workflowToken";
            correlationtoken91.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMAudit.CorrelationToken = correlationtoken91;
            this.sendEmailAGMAudit.From = null;
            this.sendEmailAGMAudit.Headers = null;
            this.sendEmailAGMAudit.IncludeStatus = false;
            this.sendEmailAGMAudit.Name = "sendEmailAGMAudit";
            this.sendEmailAGMAudit.Subject = null;
            this.sendEmailAGMAudit.To = null;
            this.sendEmailAGMAudit.MethodInvoking += new System.EventHandler(this.sendEmailAGMAudit_MethodInvoking);
            // 
            // agmAuditReviewTask
            // 
            this.agmAuditReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken92.Name = "agmAuditReviewTask";
            correlationtoken92.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmAuditReviewTask.CorrelationToken = correlationtoken92;
            this.agmAuditReviewTask.ListItemId = -1;
            this.agmAuditReviewTask.Name = "agmAuditReviewTask";
            this.agmAuditReviewTask.SpecialPermissions = null;
            activitybind199.Name = "BoardAgendaWorkflow";
            activitybind199.Path = "agmAuditReviewTask_TaskId";
            activitybind200.Name = "BoardAgendaWorkflow";
            activitybind200.Path = "agmAuditReviewTask_TaskProperties";
            this.agmAuditReviewTask.MethodInvoking += new System.EventHandler(this.agmAuditReviewTask_MethodInvoking);
            this.agmAuditReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind200)));
            this.agmAuditReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind199)));
            // 
            // logToHistoryListActivity55
            // 
            this.logToHistoryListActivity55.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity55.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity55.HistoryDescription = "Creating AGM-Audit Review Task";
            this.logToHistoryListActivity55.HistoryOutcome = "";
            this.logToHistoryListActivity55.Name = "logToHistoryListActivity55";
            this.logToHistoryListActivity55.OtherData = "";
            this.logToHistoryListActivity55.UserId = -1;
            // 
            // logToHistoryListActivity48
            // 
            this.logToHistoryListActivity48.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity48.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity48.HistoryDescription = "AGM Contracts was NOT selected";
            this.logToHistoryListActivity48.HistoryOutcome = "";
            this.logToHistoryListActivity48.Name = "logToHistoryListActivity48";
            this.logToHistoryListActivity48.OtherData = "";
            this.logToHistoryListActivity48.UserId = -1;
            // 
            // CAGforAGMContractsReviewTask
            // 
            this.CAGforAGMContractsReviewTask.Activities.Add(this.sequenceActivity53);
            this.CAGforAGMContractsReviewTask.Activities.Add(this.sequenceActivity54);
            this.CAGforAGMContractsReviewTask.Activities.Add(this.sequenceActivity55);
            this.CAGforAGMContractsReviewTask.Enabled = false;
            this.CAGforAGMContractsReviewTask.Name = "CAGforAGMContractsReviewTask";
            ruleconditionreference46.ConditionName = "AGM Contracts Review Task IS Complete";
            this.CAGforAGMContractsReviewTask.UntilCondition = ruleconditionreference46;
            // 
            // logToHistoryListActivity50
            // 
            this.logToHistoryListActivity50.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity50.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity50.HistoryDescription = "AGM Contracts Review Task Completed";
            this.logToHistoryListActivity50.HistoryOutcome = "";
            this.logToHistoryListActivity50.Name = "logToHistoryListActivity50";
            this.logToHistoryListActivity50.OtherData = "";
            this.logToHistoryListActivity50.UserId = -1;
            // 
            // agmContractsReviewTaskCompleted
            // 
            correlationtoken93.Name = "agmContractsReviewTask";
            correlationtoken93.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmContractsReviewTaskCompleted.CorrelationToken = correlationtoken93;
            this.agmContractsReviewTaskCompleted.Name = "agmContractsReviewTaskCompleted";
            activitybind201.Name = "BoardAgendaWorkflow";
            activitybind201.Path = "agmContractsReviewTask_TaskId";
            this.agmContractsReviewTaskCompleted.TaskOutcome = null;
            this.agmContractsReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind201)));
            // 
            // whileAGMContractsReviewIsNOTComplete
            // 
            this.whileAGMContractsReviewIsNOTComplete.Activities.Add(this.onAGMContractsReviewTaskChanged);
            ruleconditionreference47.ConditionName = "Check if AGM-Contracts Review task is complete";
            this.whileAGMContractsReviewIsNOTComplete.Condition = ruleconditionreference47;
            this.whileAGMContractsReviewIsNOTComplete.Name = "whileAGMContractsReviewIsNOTComplete";
            // 
            // logToHistoryListActivity47
            // 
            this.logToHistoryListActivity47.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity47.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity47.HistoryDescription = "AGM Contracts Review TASK created";
            this.logToHistoryListActivity47.HistoryOutcome = "";
            this.logToHistoryListActivity47.Name = "logToHistoryListActivity47";
            this.logToHistoryListActivity47.OtherData = "";
            this.logToHistoryListActivity47.UserId = -1;
            // 
            // sendEmailAGMContracts
            // 
            this.sendEmailAGMContracts.BCC = null;
            this.sendEmailAGMContracts.Body = null;
            this.sendEmailAGMContracts.CC = null;
            correlationtoken94.Name = "workflowToken";
            correlationtoken94.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMContracts.CorrelationToken = correlationtoken94;
            this.sendEmailAGMContracts.From = null;
            this.sendEmailAGMContracts.Headers = null;
            this.sendEmailAGMContracts.IncludeStatus = false;
            this.sendEmailAGMContracts.Name = "sendEmailAGMContracts";
            this.sendEmailAGMContracts.Subject = null;
            this.sendEmailAGMContracts.To = null;
            this.sendEmailAGMContracts.MethodInvoking += new System.EventHandler(this.sendEmailAGMContracts_MethodInvoking);
            // 
            // agmContractsReviewTask
            // 
            this.agmContractsReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken95.Name = "agmContractsReviewTask";
            correlationtoken95.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmContractsReviewTask.CorrelationToken = correlationtoken95;
            this.agmContractsReviewTask.ListItemId = -1;
            this.agmContractsReviewTask.Name = "agmContractsReviewTask";
            this.agmContractsReviewTask.SpecialPermissions = null;
            activitybind202.Name = "BoardAgendaWorkflow";
            activitybind202.Path = "agmContractsReviewTask_TaskId";
            activitybind203.Name = "BoardAgendaWorkflow";
            activitybind203.Path = "agmContractsReviewTask_TaskProperties";
            this.agmContractsReviewTask.MethodInvoking += new System.EventHandler(this.agmContractsReviewTask_MethodInvoking);
            this.agmContractsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind203)));
            this.agmContractsReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind202)));
            // 
            // logToHistoryListActivity46
            // 
            this.logToHistoryListActivity46.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity46.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity46.HistoryDescription = "Creating AGM-Contracts Review Task";
            this.logToHistoryListActivity46.HistoryOutcome = "";
            this.logToHistoryListActivity46.Name = "logToHistoryListActivity46";
            this.logToHistoryListActivity46.OtherData = "";
            this.logToHistoryListActivity46.UserId = -1;
            // 
            // logToHistoryListActivity39
            // 
            this.logToHistoryListActivity39.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity39.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity39.HistoryDescription = "AGM Legal was NOT selected";
            this.logToHistoryListActivity39.HistoryOutcome = "";
            this.logToHistoryListActivity39.Name = "logToHistoryListActivity39";
            this.logToHistoryListActivity39.OtherData = "";
            this.logToHistoryListActivity39.UserId = -1;
            // 
            // CAGforAGMLegalReviewTask
            // 
            this.CAGforAGMLegalReviewTask.Activities.Add(this.sequenceActivity50);
            this.CAGforAGMLegalReviewTask.Activities.Add(this.sequenceActivity51);
            this.CAGforAGMLegalReviewTask.Activities.Add(this.sequenceActivity52);
            this.CAGforAGMLegalReviewTask.Enabled = false;
            this.CAGforAGMLegalReviewTask.Name = "CAGforAGMLegalReviewTask";
            ruleconditionreference48.ConditionName = "AGM Legal Review Task IS Completed";
            this.CAGforAGMLegalReviewTask.UntilCondition = ruleconditionreference48;
            // 
            // logToHistoryListActivity41
            // 
            this.logToHistoryListActivity41.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity41.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity41.HistoryDescription = "AGM Legal Review Task Completed";
            this.logToHistoryListActivity41.HistoryOutcome = "";
            this.logToHistoryListActivity41.Name = "logToHistoryListActivity41";
            this.logToHistoryListActivity41.OtherData = "";
            this.logToHistoryListActivity41.UserId = -1;
            // 
            // agmLegalReviewTaskCompleted
            // 
            correlationtoken96.Name = "agmLegalReviewTask";
            correlationtoken96.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmLegalReviewTaskCompleted.CorrelationToken = correlationtoken96;
            this.agmLegalReviewTaskCompleted.Name = "agmLegalReviewTaskCompleted";
            activitybind204.Name = "BoardAgendaWorkflow";
            activitybind204.Path = "agmLegalReviewTask_TaskId";
            this.agmLegalReviewTaskCompleted.TaskOutcome = null;
            this.agmLegalReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind204)));
            // 
            // whileAGMLegalReviewIsNotComplete
            // 
            this.whileAGMLegalReviewIsNotComplete.Activities.Add(this.onAGMLegalReviewTaskChanged);
            ruleconditionreference49.ConditionName = "Check if AGM_Legal Review task is complete";
            this.whileAGMLegalReviewIsNotComplete.Condition = ruleconditionreference49;
            this.whileAGMLegalReviewIsNotComplete.Name = "whileAGMLegalReviewIsNotComplete";
            // 
            // logToHistoryListActivity38
            // 
            this.logToHistoryListActivity38.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity38.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity38.HistoryDescription = "AGM Legal Review TASK created";
            this.logToHistoryListActivity38.HistoryOutcome = "";
            this.logToHistoryListActivity38.Name = "logToHistoryListActivity38";
            this.logToHistoryListActivity38.OtherData = "";
            this.logToHistoryListActivity38.UserId = -1;
            // 
            // sendEmailAGMLegalAdmin
            // 
            this.sendEmailAGMLegalAdmin.BCC = null;
            this.sendEmailAGMLegalAdmin.Body = null;
            this.sendEmailAGMLegalAdmin.CC = null;
            correlationtoken97.Name = "workflowToken";
            correlationtoken97.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMLegalAdmin.CorrelationToken = correlationtoken97;
            this.sendEmailAGMLegalAdmin.From = null;
            this.sendEmailAGMLegalAdmin.Headers = null;
            this.sendEmailAGMLegalAdmin.IncludeStatus = false;
            this.sendEmailAGMLegalAdmin.Name = "sendEmailAGMLegalAdmin";
            this.sendEmailAGMLegalAdmin.Subject = null;
            this.sendEmailAGMLegalAdmin.To = null;
            this.sendEmailAGMLegalAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMLegalAdmin_MethodInvoking);
            // 
            // agmLegalReviewTask
            // 
            this.agmLegalReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken98.Name = "agmLegalReviewTask";
            correlationtoken98.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmLegalReviewTask.CorrelationToken = correlationtoken98;
            this.agmLegalReviewTask.ListItemId = -1;
            this.agmLegalReviewTask.Name = "agmLegalReviewTask";
            this.agmLegalReviewTask.SpecialPermissions = null;
            activitybind205.Name = "BoardAgendaWorkflow";
            activitybind205.Path = "agmLegalReviewTask_TaskId";
            activitybind206.Name = "BoardAgendaWorkflow";
            activitybind206.Path = "agmLegalReviewTask_TaskProperties";
            this.agmLegalReviewTask.MethodInvoking += new System.EventHandler(this.agmLegalReviewTask_MethodInvoking);
            this.agmLegalReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind206)));
            this.agmLegalReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind205)));
            // 
            // logToHistoryListActivity37
            // 
            this.logToHistoryListActivity37.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity37.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity37.HistoryDescription = "Creating AGM-Legal Review Task";
            this.logToHistoryListActivity37.HistoryOutcome = "";
            this.logToHistoryListActivity37.Name = "logToHistoryListActivity37";
            this.logToHistoryListActivity37.OtherData = "";
            this.logToHistoryListActivity37.UserId = -1;
            // 
            // logToHistoryListActivity30
            // 
            this.logToHistoryListActivity30.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity30.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity30.HistoryDescription = "AGM Safety was NOT selected";
            this.logToHistoryListActivity30.HistoryOutcome = "";
            this.logToHistoryListActivity30.Name = "logToHistoryListActivity30";
            this.logToHistoryListActivity30.OtherData = "";
            this.logToHistoryListActivity30.UserId = -1;
            // 
            // CAGForSafetyReviewTask
            // 
            this.CAGForSafetyReviewTask.Activities.Add(this.sequenceActivity47);
            this.CAGForSafetyReviewTask.Activities.Add(this.sequenceActivity48);
            this.CAGForSafetyReviewTask.Activities.Add(this.sequenceActivity49);
            this.CAGForSafetyReviewTask.Enabled = false;
            this.CAGForSafetyReviewTask.Name = "CAGForSafetyReviewTask";
            ruleconditionreference50.ConditionName = "AGM Safety Review Task IS completed";
            this.CAGForSafetyReviewTask.UntilCondition = ruleconditionreference50;
            // 
            // logToHistoryListActivity32
            // 
            this.logToHistoryListActivity32.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity32.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity32.HistoryDescription = "AGM Safety Review Task Completed";
            this.logToHistoryListActivity32.HistoryOutcome = "";
            this.logToHistoryListActivity32.Name = "logToHistoryListActivity32";
            this.logToHistoryListActivity32.OtherData = "";
            this.logToHistoryListActivity32.UserId = -1;
            // 
            // agmSafetyReviewTaskCompleted
            // 
            correlationtoken99.Name = "agmSafetyReviewTask";
            correlationtoken99.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmSafetyReviewTaskCompleted.CorrelationToken = correlationtoken99;
            this.agmSafetyReviewTaskCompleted.Name = "agmSafetyReviewTaskCompleted";
            activitybind207.Name = "BoardAgendaWorkflow";
            activitybind207.Path = "agmSafetyReviewTask_TaskId";
            this.agmSafetyReviewTaskCompleted.TaskOutcome = null;
            this.agmSafetyReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind207)));
            // 
            // whileAGMSafetyReviewIsNotComplete
            // 
            this.whileAGMSafetyReviewIsNotComplete.Activities.Add(this.onAGMSafetyReviewTaskChanged);
            ruleconditionreference51.ConditionName = "Check if AGM Safety Review task is complete";
            this.whileAGMSafetyReviewIsNotComplete.Condition = ruleconditionreference51;
            this.whileAGMSafetyReviewIsNotComplete.Name = "whileAGMSafetyReviewIsNotComplete";
            // 
            // logToHistoryListActivity29
            // 
            this.logToHistoryListActivity29.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity29.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity29.HistoryDescription = "AGM Safety Review TASK created";
            this.logToHistoryListActivity29.HistoryOutcome = "";
            this.logToHistoryListActivity29.Name = "logToHistoryListActivity29";
            this.logToHistoryListActivity29.OtherData = "";
            this.logToHistoryListActivity29.UserId = -1;
            // 
            // sendEmailAGMSafetyAdmin
            // 
            this.sendEmailAGMSafetyAdmin.BCC = null;
            this.sendEmailAGMSafetyAdmin.Body = null;
            this.sendEmailAGMSafetyAdmin.CC = null;
            correlationtoken100.Name = "workflowToken";
            correlationtoken100.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMSafetyAdmin.CorrelationToken = correlationtoken100;
            this.sendEmailAGMSafetyAdmin.From = null;
            this.sendEmailAGMSafetyAdmin.Headers = null;
            this.sendEmailAGMSafetyAdmin.IncludeStatus = false;
            this.sendEmailAGMSafetyAdmin.Name = "sendEmailAGMSafetyAdmin";
            this.sendEmailAGMSafetyAdmin.Subject = null;
            this.sendEmailAGMSafetyAdmin.To = null;
            this.sendEmailAGMSafetyAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMSafetyAdmin_MethodInvoking);
            // 
            // agmSafetyReviewTask
            // 
            this.agmSafetyReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken101.Name = "agmSafetyReviewTask";
            correlationtoken101.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmSafetyReviewTask.CorrelationToken = correlationtoken101;
            this.agmSafetyReviewTask.ListItemId = -1;
            this.agmSafetyReviewTask.Name = "agmSafetyReviewTask";
            this.agmSafetyReviewTask.SpecialPermissions = null;
            activitybind208.Name = "BoardAgendaWorkflow";
            activitybind208.Path = "agmSafetyReviewTask_TaskId";
            activitybind209.Name = "BoardAgendaWorkflow";
            activitybind209.Path = "agmSafetyReviewTask_TaskProperties";
            this.agmSafetyReviewTask.MethodInvoking += new System.EventHandler(this.agmSafetyReviewTask_MethodInvoking);
            this.agmSafetyReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind209)));
            this.agmSafetyReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind208)));
            // 
            // logToHistoryListActivity28
            // 
            this.logToHistoryListActivity28.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity28.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity28.HistoryDescription = "Creating AGM-Safety Review Task";
            this.logToHistoryListActivity28.HistoryOutcome = "";
            this.logToHistoryListActivity28.Name = "logToHistoryListActivity28";
            this.logToHistoryListActivity28.OtherData = "";
            this.logToHistoryListActivity28.UserId = -1;
            // 
            // logToHistoryListActivity21
            // 
            this.logToHistoryListActivity21.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity21.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity21.HistoryDescription = "AGM Human Resources was NOT selected";
            this.logToHistoryListActivity21.HistoryOutcome = "";
            this.logToHistoryListActivity21.Name = "logToHistoryListActivity21";
            this.logToHistoryListActivity21.OtherData = "";
            this.logToHistoryListActivity21.UserId = -1;
            // 
            // CAGForAGMHumanResourcesReviewTask
            // 
            this.CAGForAGMHumanResourcesReviewTask.Activities.Add(this.sequenceActivity44);
            this.CAGForAGMHumanResourcesReviewTask.Activities.Add(this.sequenceActivity45);
            this.CAGForAGMHumanResourcesReviewTask.Activities.Add(this.sequenceActivity46);
            this.CAGForAGMHumanResourcesReviewTask.Enabled = false;
            this.CAGForAGMHumanResourcesReviewTask.Name = "CAGForAGMHumanResourcesReviewTask";
            ruleconditionreference52.ConditionName = "AGM HumanResources Task IS completed";
            this.CAGForAGMHumanResourcesReviewTask.UntilCondition = ruleconditionreference52;
            // 
            // logToHistoryListActivity23
            // 
            this.logToHistoryListActivity23.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity23.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity23.HistoryDescription = "AGM HumanResources Review Task Completed";
            this.logToHistoryListActivity23.HistoryOutcome = "";
            this.logToHistoryListActivity23.Name = "logToHistoryListActivity23";
            this.logToHistoryListActivity23.OtherData = "";
            this.logToHistoryListActivity23.UserId = -1;
            // 
            // agmHumanResourcesReviewTaskCompleted
            // 
            correlationtoken102.Name = "agmHumanResourcesReviewTask";
            correlationtoken102.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmHumanResourcesReviewTaskCompleted.CorrelationToken = correlationtoken102;
            this.agmHumanResourcesReviewTaskCompleted.Name = "agmHumanResourcesReviewTaskCompleted";
            activitybind210.Name = "BoardAgendaWorkflow";
            activitybind210.Path = "agmHumanResourcesReviewTask_TaskId";
            this.agmHumanResourcesReviewTaskCompleted.TaskOutcome = null;
            this.agmHumanResourcesReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind210)));
            // 
            // whileAGMHumanResourcesTaskNotComplete
            // 
            this.whileAGMHumanResourcesTaskNotComplete.Activities.Add(this.onAGMHumanResourcesReviewTaskChanged);
            ruleconditionreference53.ConditionName = "Check if AGM_Finance Review Task is complete";
            this.whileAGMHumanResourcesTaskNotComplete.Condition = ruleconditionreference53;
            this.whileAGMHumanResourcesTaskNotComplete.Name = "whileAGMHumanResourcesTaskNotComplete";
            // 
            // logToHistoryListActivity20
            // 
            this.logToHistoryListActivity20.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity20.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity20.HistoryDescription = "AGM Human Resources Review TASK created";
            this.logToHistoryListActivity20.HistoryOutcome = "";
            this.logToHistoryListActivity20.Name = "logToHistoryListActivity20";
            this.logToHistoryListActivity20.OtherData = "";
            this.logToHistoryListActivity20.UserId = -1;
            // 
            // sendEmailHumanResourcesAdmin
            // 
            this.sendEmailHumanResourcesAdmin.BCC = null;
            this.sendEmailHumanResourcesAdmin.Body = null;
            this.sendEmailHumanResourcesAdmin.CC = null;
            correlationtoken103.Name = "workflowToken";
            correlationtoken103.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailHumanResourcesAdmin.CorrelationToken = correlationtoken103;
            this.sendEmailHumanResourcesAdmin.From = null;
            this.sendEmailHumanResourcesAdmin.Headers = null;
            this.sendEmailHumanResourcesAdmin.IncludeStatus = false;
            this.sendEmailHumanResourcesAdmin.Name = "sendEmailHumanResourcesAdmin";
            this.sendEmailHumanResourcesAdmin.Subject = null;
            this.sendEmailHumanResourcesAdmin.To = null;
            this.sendEmailHumanResourcesAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMHumanResources_MethodInvoking);
            // 
            // agmHumanResourcesReviewTask
            // 
            this.agmHumanResourcesReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken104.Name = "agmHumanResourcesReviewTask";
            correlationtoken104.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmHumanResourcesReviewTask.CorrelationToken = correlationtoken104;
            this.agmHumanResourcesReviewTask.ListItemId = -1;
            this.agmHumanResourcesReviewTask.Name = "agmHumanResourcesReviewTask";
            this.agmHumanResourcesReviewTask.SpecialPermissions = null;
            activitybind211.Name = "BoardAgendaWorkflow";
            activitybind211.Path = "agmHumanResourcesReviewTask_TaskId";
            activitybind212.Name = "BoardAgendaWorkflow";
            activitybind212.Path = "agmHumanResourcesReviewTask_TaskProperties";
            this.agmHumanResourcesReviewTask.MethodInvoking += new System.EventHandler(this.agmHumanResourcesReviewTask_MethodInvoking);
            this.agmHumanResourcesReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind212)));
            this.agmHumanResourcesReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind211)));
            // 
            // logToHistoryListActivity19
            // 
            this.logToHistoryListActivity19.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity19.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity19.HistoryDescription = "Creating AGM-HumanResources Review Task";
            this.logToHistoryListActivity19.HistoryOutcome = "";
            this.logToHistoryListActivity19.Name = "logToHistoryListActivity19";
            this.logToHistoryListActivity19.OtherData = "";
            this.logToHistoryListActivity19.UserId = -1;
            // 
            // logToHistoryListActivity12
            // 
            this.logToHistoryListActivity12.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity12.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity12.HistoryDescription = "AGM Planning was NOT selected";
            this.logToHistoryListActivity12.HistoryOutcome = "";
            this.logToHistoryListActivity12.Name = "logToHistoryListActivity12";
            this.logToHistoryListActivity12.OtherData = "";
            this.logToHistoryListActivity12.UserId = -1;
            // 
            // CAGForAGMPlanningReviewTask
            // 
            this.CAGForAGMPlanningReviewTask.Activities.Add(this.sequenceActivity41);
            this.CAGForAGMPlanningReviewTask.Activities.Add(this.sequenceActivity42);
            this.CAGForAGMPlanningReviewTask.Activities.Add(this.sequenceActivity43);
            this.CAGForAGMPlanningReviewTask.Enabled = false;
            this.CAGForAGMPlanningReviewTask.Name = "CAGForAGMPlanningReviewTask";
            ruleconditionreference54.ConditionName = "AGM Planning Review Task IS completed";
            this.CAGForAGMPlanningReviewTask.UntilCondition = ruleconditionreference54;
            // 
            // logToHistoryListActivity14
            // 
            this.logToHistoryListActivity14.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity14.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity14.HistoryDescription = "AGM Planning Review Task Completed";
            this.logToHistoryListActivity14.HistoryOutcome = "";
            this.logToHistoryListActivity14.Name = "logToHistoryListActivity14";
            this.logToHistoryListActivity14.OtherData = "";
            this.logToHistoryListActivity14.UserId = -1;
            // 
            // agmPlanningReviewTaskCompleted
            // 
            correlationtoken105.Name = "agmPlanningReviewTask";
            correlationtoken105.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPlanningReviewTaskCompleted.CorrelationToken = correlationtoken105;
            this.agmPlanningReviewTaskCompleted.Name = "agmPlanningReviewTaskCompleted";
            activitybind213.Name = "BoardAgendaWorkflow";
            activitybind213.Path = "agmPlanningReviewTask_TaskId";
            this.agmPlanningReviewTaskCompleted.TaskOutcome = null;
            this.agmPlanningReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind213)));
            // 
            // whileAGMPlanningReviewTaskNotComplete
            // 
            this.whileAGMPlanningReviewTaskNotComplete.Activities.Add(this.onAGMPlanningTaskChanged);
            ruleconditionreference55.ConditionName = "Check if AGM Planning Review Task is complete";
            this.whileAGMPlanningReviewTaskNotComplete.Condition = ruleconditionreference55;
            this.whileAGMPlanningReviewTaskNotComplete.Name = "whileAGMPlanningReviewTaskNotComplete";
            // 
            // logToHistoryListActivity11
            // 
            this.logToHistoryListActivity11.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity11.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity11.HistoryDescription = "AGM Planning Review TASK created";
            this.logToHistoryListActivity11.HistoryOutcome = "";
            this.logToHistoryListActivity11.Name = "logToHistoryListActivity11";
            this.logToHistoryListActivity11.OtherData = "";
            this.logToHistoryListActivity11.UserId = -1;
            // 
            // sendEmailAGMPlanningAdmin
            // 
            this.sendEmailAGMPlanningAdmin.BCC = null;
            this.sendEmailAGMPlanningAdmin.Body = null;
            this.sendEmailAGMPlanningAdmin.CC = null;
            correlationtoken106.Name = "workflowToken";
            correlationtoken106.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMPlanningAdmin.CorrelationToken = correlationtoken106;
            this.sendEmailAGMPlanningAdmin.From = null;
            this.sendEmailAGMPlanningAdmin.Headers = null;
            this.sendEmailAGMPlanningAdmin.IncludeStatus = false;
            this.sendEmailAGMPlanningAdmin.Name = "sendEmailAGMPlanningAdmin";
            this.sendEmailAGMPlanningAdmin.Subject = null;
            this.sendEmailAGMPlanningAdmin.To = null;
            this.sendEmailAGMPlanningAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMPlanningAdmin_MethodInvoking);
            // 
            // agmPlanningReviewTask
            // 
            this.agmPlanningReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken107.Name = "agmPlanningReviewTask";
            correlationtoken107.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmPlanningReviewTask.CorrelationToken = correlationtoken107;
            this.agmPlanningReviewTask.ListItemId = -1;
            this.agmPlanningReviewTask.Name = "agmPlanningReviewTask";
            this.agmPlanningReviewTask.SpecialPermissions = null;
            activitybind214.Name = "BoardAgendaWorkflow";
            activitybind214.Path = "agmPlanningReviewTask_TaskId";
            activitybind215.Name = "BoardAgendaWorkflow";
            activitybind215.Path = "agmPlanningReviewTask_TaskProperties";
            this.agmPlanningReviewTask.MethodInvoking += new System.EventHandler(this.agmPlanningReviewTask_MethodInvoking);
            this.agmPlanningReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind215)));
            this.agmPlanningReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind214)));
            // 
            // logToHistoryListActivity10
            // 
            this.logToHistoryListActivity10.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity10.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity10.HistoryDescription = "Creating AGM-Planning Review Task";
            this.logToHistoryListActivity10.HistoryOutcome = "";
            this.logToHistoryListActivity10.Name = "logToHistoryListActivity10";
            this.logToHistoryListActivity10.OtherData = "";
            this.logToHistoryListActivity10.UserId = -1;
            // 
            // logToHistoryListActivity3
            // 
            this.logToHistoryListActivity3.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity3.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity3.HistoryDescription = "AGM IT was NOT selected";
            this.logToHistoryListActivity3.HistoryOutcome = "";
            this.logToHistoryListActivity3.Name = "logToHistoryListActivity3";
            this.logToHistoryListActivity3.OtherData = "";
            this.logToHistoryListActivity3.UserId = -1;
            // 
            // CAGforAGM_ITReviewTask
            // 
            this.CAGforAGM_ITReviewTask.Activities.Add(this.sequenceActivity38);
            this.CAGforAGM_ITReviewTask.Activities.Add(this.sequenceActivity39);
            this.CAGforAGM_ITReviewTask.Activities.Add(this.sequenceActivity40);
            this.CAGforAGM_ITReviewTask.Enabled = false;
            this.CAGforAGM_ITReviewTask.Name = "CAGforAGM_ITReviewTask";
            ruleconditionreference56.ConditionName = "AGM IT Review Task IS completed";
            this.CAGforAGM_ITReviewTask.UntilCondition = ruleconditionreference56;
            // 
            // logToHistoryListActivity5
            // 
            this.logToHistoryListActivity5.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity5.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity5.HistoryDescription = "AGM IT Review Task Completed";
            this.logToHistoryListActivity5.HistoryOutcome = "";
            this.logToHistoryListActivity5.Name = "logToHistoryListActivity5";
            this.logToHistoryListActivity5.OtherData = "";
            this.logToHistoryListActivity5.UserId = -1;
            // 
            // agmITReviewTaskCompleted
            // 
            correlationtoken108.Name = "agmITReviewTask";
            correlationtoken108.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmITReviewTaskCompleted.CorrelationToken = correlationtoken108;
            this.agmITReviewTaskCompleted.Name = "agmITReviewTaskCompleted";
            activitybind216.Name = "BoardAgendaWorkflow";
            activitybind216.Path = "agmITReviewTask_TaskId";
            this.agmITReviewTaskCompleted.TaskOutcome = null;
            this.agmITReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind216)));
            // 
            // whileAGMITReviewIsNotComplete
            // 
            this.whileAGMITReviewIsNotComplete.Activities.Add(this.onAGMITReviewTaskChanged);
            ruleconditionreference57.ConditionName = "Check if AGM IT Review Task is complete";
            this.whileAGMITReviewIsNotComplete.Condition = ruleconditionreference57;
            this.whileAGMITReviewIsNotComplete.Name = "whileAGMITReviewIsNotComplete";
            // 
            // logToHistoryListActivity2
            // 
            this.logToHistoryListActivity2.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity2.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity2.HistoryDescription = "AGM IT Review TASK created";
            this.logToHistoryListActivity2.HistoryOutcome = "";
            this.logToHistoryListActivity2.Name = "logToHistoryListActivity2";
            this.logToHistoryListActivity2.OtherData = "";
            this.logToHistoryListActivity2.UserId = -1;
            // 
            // sendEmailAGMITAdmin
            // 
            this.sendEmailAGMITAdmin.BCC = null;
            this.sendEmailAGMITAdmin.Body = null;
            this.sendEmailAGMITAdmin.CC = null;
            correlationtoken109.Name = "workflowToken";
            correlationtoken109.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMITAdmin.CorrelationToken = correlationtoken109;
            this.sendEmailAGMITAdmin.From = null;
            this.sendEmailAGMITAdmin.Headers = null;
            this.sendEmailAGMITAdmin.IncludeStatus = false;
            this.sendEmailAGMITAdmin.Name = "sendEmailAGMITAdmin";
            this.sendEmailAGMITAdmin.Subject = null;
            this.sendEmailAGMITAdmin.To = null;
            this.sendEmailAGMITAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMITAdmin_MethodInvoking);
            // 
            // agmITReviewTask
            // 
            this.agmITReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken110.Name = "agmITReviewTask";
            correlationtoken110.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmITReviewTask.CorrelationToken = correlationtoken110;
            this.agmITReviewTask.ListItemId = -1;
            this.agmITReviewTask.Name = "agmITReviewTask";
            this.agmITReviewTask.SpecialPermissions = null;
            activitybind217.Name = "BoardAgendaWorkflow";
            activitybind217.Path = "agmITReviewTask_TaskId";
            activitybind218.Name = "BoardAgendaWorkflow";
            activitybind218.Path = "agmITReviewTask_TaskProperties";
            this.agmITReviewTask.MethodInvoking += new System.EventHandler(this.agmITReviewTask_MethodInvoking);
            this.agmITReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind218)));
            this.agmITReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind217)));
            // 
            // logToHistoryListActivity1
            // 
            this.logToHistoryListActivity1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity1.HistoryDescription = "Creating AGM-IT Review Task";
            this.logToHistoryListActivity1.HistoryOutcome = "";
            this.logToHistoryListActivity1.Name = "logToHistoryListActivity1";
            this.logToHistoryListActivity1.OtherData = "";
            this.logToHistoryListActivity1.UserId = -1;
            // 
            // logAGMFinanceNotSelected
            // 
            this.logAGMFinanceNotSelected.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceNotSelected.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceNotSelected.HistoryDescription = "AGM Finance was NOT selected";
            this.logAGMFinanceNotSelected.HistoryOutcome = "";
            this.logAGMFinanceNotSelected.Name = "logAGMFinanceNotSelected";
            this.logAGMFinanceNotSelected.OtherData = "";
            this.logAGMFinanceNotSelected.UserId = -1;
            // 
            // CAGforAGMFinanceReviewTask
            // 
            this.CAGforAGMFinanceReviewTask.Activities.Add(this.agmReviewTaskCreatedSequence);
            this.CAGforAGMFinanceReviewTask.Activities.Add(this.agmReviewTaskCompletedSequence);
            this.CAGforAGMFinanceReviewTask.Activities.Add(this.agmFinanceReviewDueDateMonitorSequence);
            this.CAGforAGMFinanceReviewTask.Enabled = false;
            this.CAGforAGMFinanceReviewTask.Name = "CAGforAGMFinanceReviewTask";
            ruleconditionreference58.ConditionName = "AGM Finance Review Task IS completed";
            this.CAGforAGMFinanceReviewTask.UntilCondition = ruleconditionreference58;
            // 
            // logAGMFinanceReviewTaskCompleted
            // 
            this.logAGMFinanceReviewTaskCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewTaskCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewTaskCompleted.HistoryDescription = "AGM Finance Review Task Completed";
            this.logAGMFinanceReviewTaskCompleted.HistoryOutcome = "";
            this.logAGMFinanceReviewTaskCompleted.Name = "logAGMFinanceReviewTaskCompleted";
            this.logAGMFinanceReviewTaskCompleted.OtherData = "";
            this.logAGMFinanceReviewTaskCompleted.UserId = -1;
            // 
            // agmFinanceReviewTaskCompleted
            // 
            correlationtoken111.Name = "agmFinanceReviewTask";
            correlationtoken111.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmFinanceReviewTaskCompleted.CorrelationToken = correlationtoken111;
            this.agmFinanceReviewTaskCompleted.Name = "agmFinanceReviewTaskCompleted";
            activitybind219.Name = "BoardAgendaWorkflow";
            activitybind219.Path = "agmFinanceReviewTask_TaskId";
            this.agmFinanceReviewTaskCompleted.TaskOutcome = null;
            this.agmFinanceReviewTaskCompleted.MethodInvoking += new System.EventHandler(this.agmFinanceReviewTaskCompleted_MethodInvoking);
            this.agmFinanceReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind219)));
            // 
            // whileAGMFinanceReviewIsNotComplete
            // 
            this.whileAGMFinanceReviewIsNotComplete.Activities.Add(this.onAGMFinanceReviewTaskChanged);
            ruleconditionreference59.ConditionName = "Check if AGM_Finance Review Task is complete";
            this.whileAGMFinanceReviewIsNotComplete.Condition = ruleconditionreference59;
            this.whileAGMFinanceReviewIsNotComplete.Name = "whileAGMFinanceReviewIsNotComplete";
            // 
            // logAGMFinanceReviewTaskCreated
            // 
            this.logAGMFinanceReviewTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceReviewTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceReviewTaskCreated.HistoryDescription = "AGM Finance Review TASK created";
            this.logAGMFinanceReviewTaskCreated.HistoryOutcome = "";
            this.logAGMFinanceReviewTaskCreated.Name = "logAGMFinanceReviewTaskCreated";
            this.logAGMFinanceReviewTaskCreated.OtherData = "";
            this.logAGMFinanceReviewTaskCreated.UserId = -1;
            // 
            // sendEmailAGMFinanceAdmin
            // 
            this.sendEmailAGMFinanceAdmin.BCC = null;
            this.sendEmailAGMFinanceAdmin.Body = null;
            this.sendEmailAGMFinanceAdmin.CC = null;
            correlationtoken112.Name = "workflowToken";
            correlationtoken112.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmailAGMFinanceAdmin.CorrelationToken = correlationtoken112;
            this.sendEmailAGMFinanceAdmin.From = null;
            this.sendEmailAGMFinanceAdmin.Headers = null;
            this.sendEmailAGMFinanceAdmin.IncludeStatus = false;
            this.sendEmailAGMFinanceAdmin.Name = "sendEmailAGMFinanceAdmin";
            this.sendEmailAGMFinanceAdmin.Subject = null;
            this.sendEmailAGMFinanceAdmin.To = null;
            this.sendEmailAGMFinanceAdmin.MethodInvoking += new System.EventHandler(this.sendEmailAGMFinance_MethodInvoking);
            // 
            // agmFinanceReviewTask
            // 
            this.agmFinanceReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            correlationtoken113.Name = "agmFinanceReviewTask";
            correlationtoken113.OwnerActivityName = "BoardAgendaWorkflow";
            this.agmFinanceReviewTask.CorrelationToken = correlationtoken113;
            this.agmFinanceReviewTask.ListItemId = -1;
            this.agmFinanceReviewTask.Name = "agmFinanceReviewTask";
            this.agmFinanceReviewTask.SpecialPermissions = null;
            activitybind220.Name = "BoardAgendaWorkflow";
            activitybind220.Path = "agmFinanceReviewTask_TaskId";
            activitybind221.Name = "BoardAgendaWorkflow";
            activitybind221.Path = "agmFinanceReviewTask_TaskProperties";
            this.agmFinanceReviewTask.MethodInvoking += new System.EventHandler(this.agmFinanceReviewTask_MethodInvoking);
            this.agmFinanceReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind221)));
            this.agmFinanceReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind220)));
            // 
            // logAGMFinanceSelected
            // 
            this.logAGMFinanceSelected.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAGMFinanceSelected.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAGMFinanceSelected.HistoryDescription = "Creating AGM-Finance Review Task";
            this.logAGMFinanceSelected.HistoryOutcome = "";
            this.logAGMFinanceSelected.Name = "logAGMFinanceSelected";
            this.logAGMFinanceSelected.OtherData = "";
            this.logAGMFinanceSelected.UserId = -1;
            // 
            // logToHistoryListActivity148
            // 
            this.logToHistoryListActivity148.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity148.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity148.HistoryDescription = "DGM Review Task Delay - awakening";
            this.logToHistoryListActivity148.HistoryOutcome = "";
            this.logToHistoryListActivity148.Name = "logToHistoryListActivity148";
            this.logToHistoryListActivity148.OtherData = "";
            this.logToHistoryListActivity148.UserId = -1;
            // 
            // delayActivity17
            // 
            this.delayActivity17.Name = "delayActivity17";
            this.delayActivity17.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity147
            // 
            this.logToHistoryListActivity147.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity147.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity147.HistoryDescription = "DGM Review Task Delay - sleeping";
            this.logToHistoryListActivity147.HistoryOutcome = "";
            this.logToHistoryListActivity147.Name = "logToHistoryListActivity147";
            this.logToHistoryListActivity147.OtherData = "";
            this.logToHistoryListActivity147.UserId = -1;
            // 
            // logToHistoryListActivity146
            // 
            this.logToHistoryListActivity146.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity146.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity146.HistoryDescription = "DGM Review Task set to expired";
            this.logToHistoryListActivity146.HistoryOutcome = "";
            this.logToHistoryListActivity146.Name = "logToHistoryListActivity146";
            this.logToHistoryListActivity146.OtherData = "";
            this.logToHistoryListActivity146.UserId = -1;
            // 
            // onTaskChanged6
            // 
            activitybind222.Name = "BoardAgendaWorkflow";
            activitybind222.Path = "onDGMReviewTaskUpdated_AfterProperties";
            activitybind223.Name = "BoardAgendaWorkflow";
            activitybind223.Path = "onDGMReviewTaskUpdated_BeforeProperties";
            correlationtoken114.Name = "DGMApproveTask";
            correlationtoken114.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskChanged6.CorrelationToken = correlationtoken114;
            this.onTaskChanged6.Executor = null;
            this.onTaskChanged6.Name = "onTaskChanged6";
            activitybind224.Name = "BoardAgendaWorkflow";
            activitybind224.Path = "DGMApproveTask_TaskId";
            this.onTaskChanged6.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskUpdated_Invoked);
            this.onTaskChanged6.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind223)));
            this.onTaskChanged6.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind224)));
            this.onTaskChanged6.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind222)));
            // 
            // updateTask4
            // 
            correlationtoken115.Name = "DGMApproveTask";
            correlationtoken115.OwnerActivityName = "BoardAgendaWorkflow";
            this.updateTask4.CorrelationToken = correlationtoken115;
            this.updateTask4.Name = "updateTask4";
            activitybind225.Name = "BoardAgendaWorkflow";
            activitybind225.Path = "DGMApproveTask_TaskId";
            activitybind226.Name = "BoardAgendaWorkflow";
            activitybind226.Path = "updateDGMReviewTaskToExpired_TaskProperties";
            this.updateTask4.MethodInvoking += new System.EventHandler(this.updateDGMReviewTaskToExpired_MethodInvoking);
            this.updateTask4.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind226)));
            this.updateTask4.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind225)));
            // 
            // logToHistoryListActivity142
            // 
            this.logToHistoryListActivity142.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity142.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity142.HistoryDescription = "DGM Review Task Delay - awakening";
            this.logToHistoryListActivity142.HistoryOutcome = "";
            this.logToHistoryListActivity142.Name = "logToHistoryListActivity142";
            this.logToHistoryListActivity142.OtherData = "";
            this.logToHistoryListActivity142.UserId = -1;
            // 
            // delayActivity16
            // 
            this.delayActivity16.Name = "delayActivity16";
            this.delayActivity16.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logToHistoryListActivity141
            // 
            this.logToHistoryListActivity141.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity141.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity141.HistoryDescription = "DGM Review Task Delay - sleeping";
            this.logToHistoryListActivity141.HistoryOutcome = "";
            this.logToHistoryListActivity141.Name = "logToHistoryListActivity141";
            this.logToHistoryListActivity141.OtherData = "";
            this.logToHistoryListActivity141.UserId = -1;
            // 
            // logToHistoryListActivity140
            // 
            this.logToHistoryListActivity140.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity140.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity140.HistoryDescription = "DGM Review Task set to expired";
            this.logToHistoryListActivity140.HistoryOutcome = "";
            this.logToHistoryListActivity140.Name = "logToHistoryListActivity140";
            this.logToHistoryListActivity140.OtherData = "";
            this.logToHistoryListActivity140.UserId = -1;
            // 
            // onTaskChanged4
            // 
            activitybind227.Name = "BoardAgendaWorkflow";
            activitybind227.Path = "onDGMReviewTaskUpdated_AfterProperties";
            activitybind228.Name = "BoardAgendaWorkflow";
            activitybind228.Path = "onDGMReviewTaskUpdated_BeforeProperties";
            correlationtoken116.Name = "DGMApproveTask";
            correlationtoken116.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskChanged4.CorrelationToken = correlationtoken116;
            this.onTaskChanged4.Executor = null;
            this.onTaskChanged4.Name = "onTaskChanged4";
            activitybind229.Name = "BoardAgendaWorkflow";
            activitybind229.Path = "DGMApproveTask_TaskId";
            this.onTaskChanged4.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskUpdated_Invoked);
            this.onTaskChanged4.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind228)));
            this.onTaskChanged4.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind229)));
            this.onTaskChanged4.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind227)));
            // 
            // updateTask3
            // 
            correlationtoken117.Name = "DGMApproveTask";
            correlationtoken117.OwnerActivityName = "BoardAgendaWorkflow";
            this.updateTask3.CorrelationToken = correlationtoken117;
            this.updateTask3.Name = "updateTask3";
            activitybind230.Name = "BoardAgendaWorkflow";
            activitybind230.Path = "DGMApproveTask_TaskId";
            activitybind231.Name = "BoardAgendaWorkflow";
            activitybind231.Path = "updateDGMReviewTaskToExpired_TaskProperties";
            this.updateTask3.MethodInvoking += new System.EventHandler(this.updateDGMReviewTaskToExpired_MethodInvoking);
            this.updateTask3.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind231)));
            this.updateTask3.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind230)));
            // 
            // sequenceActivity37
            // 
            this.sequenceActivity37.Activities.Add(this.sequenceActivity93);
            this.sequenceActivity37.Name = "sequenceActivity37";
            // 
            // sequenceActivity36
            // 
            this.sequenceActivity36.Activities.Add(this.ifElseAGMRailOperationsSelected);
            this.sequenceActivity36.Name = "sequenceActivity36";
            // 
            // sequenceActivity35
            // 
            this.sequenceActivity35.Activities.Add(this.ifElseAGMBusOperationsSelected);
            this.sequenceActivity35.Name = "sequenceActivity35";
            // 
            // sequenceActivity34
            // 
            this.sequenceActivity34.Activities.Add(this.ifElseAdHocUser4Selected);
            this.sequenceActivity34.Name = "sequenceActivity34";
            // 
            // ifElseBranchActivity26
            // 
            this.ifElseBranchActivity26.Activities.Add(this.logToHistoryListActivity102);
            ruleconditionreference60.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity26.Condition = ruleconditionreference60;
            this.ifElseBranchActivity26.Name = "ifElseBranchActivity26";
            // 
            // ifElseBranchActivity25
            // 
            this.ifElseBranchActivity25.Activities.Add(this.logToHistoryListActivity100);
            this.ifElseBranchActivity25.Activities.Add(this.adHocUser3ReviewTask);
            this.ifElseBranchActivity25.Activities.Add(this.logToHistoryListActivity101);
            this.ifElseBranchActivity25.Activities.Add(this.whileAdHocUser3ReviewTaskIsNOTComplete);
            this.ifElseBranchActivity25.Activities.Add(this.adHocUser3ReviewTaskCompleted);
            this.ifElseBranchActivity25.Activities.Add(this.logToHistoryListActivity104);
            this.ifElseBranchActivity25.Activities.Add(this.CAGforAdHocUser3ReviewTask);
            ruleconditionreference61.ConditionName = "Check if Adhoc User3 is selected";
            this.ifElseBranchActivity25.Condition = ruleconditionreference61;
            this.ifElseBranchActivity25.Name = "ifElseBranchActivity25";
            // 
            // ifElseBranchActivity24
            // 
            this.ifElseBranchActivity24.Activities.Add(this.logToHistoryListActivity93);
            ruleconditionreference62.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity24.Condition = ruleconditionreference62;
            this.ifElseBranchActivity24.Name = "ifElseBranchActivity24";
            // 
            // ifElseBranchActivity23
            // 
            this.ifElseBranchActivity23.Activities.Add(this.logToHistoryListActivity91);
            this.ifElseBranchActivity23.Activities.Add(this.adHocUser2ReviewTask);
            this.ifElseBranchActivity23.Activities.Add(this.logToHistoryListActivity92);
            this.ifElseBranchActivity23.Activities.Add(this.whileAdHocUser2ReviewTaskNOTComplete);
            this.ifElseBranchActivity23.Activities.Add(this.adHocUser2ReviewTaskCompleted);
            this.ifElseBranchActivity23.Activities.Add(this.logToHistoryListActivity95);
            this.ifElseBranchActivity23.Activities.Add(this.CAGforAdHocUser2ReviewTask);
            ruleconditionreference63.ConditionName = "Check if Adhoc User2 is selected";
            this.ifElseBranchActivity23.Condition = ruleconditionreference63;
            this.ifElseBranchActivity23.Name = "ifElseBranchActivity23";
            // 
            // ifElseBranchActivity22
            // 
            this.ifElseBranchActivity22.Activities.Add(this.logToHistoryListActivity84);
            ruleconditionreference64.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity22.Condition = ruleconditionreference64;
            this.ifElseBranchActivity22.Name = "ifElseBranchActivity22";
            // 
            // ifElseBranchActivity21
            // 
            this.ifElseBranchActivity21.Activities.Add(this.logToHistoryListActivity82);
            this.ifElseBranchActivity21.Activities.Add(this.adHocUser1ReviewTask);
            this.ifElseBranchActivity21.Activities.Add(this.logToHistoryListActivity83);
            this.ifElseBranchActivity21.Activities.Add(this.whileAdhocUser1ReviewTaskIsNotComplete);
            this.ifElseBranchActivity21.Activities.Add(this.adHocUser1ReviewTaskCompleted);
            this.ifElseBranchActivity21.Activities.Add(this.logToHistoryListActivity86);
            this.ifElseBranchActivity21.Activities.Add(this.CAGforAdHocUser1ReviewTask);
            ruleconditionreference65.ConditionName = "Check if Adhoc User1 is selected";
            this.ifElseBranchActivity21.Condition = ruleconditionreference65;
            this.ifElseBranchActivity21.Name = "ifElseBranchActivity21";
            // 
            // ifElseBranchActivity20
            // 
            this.ifElseBranchActivity20.Activities.Add(this.logToHistoryListActivity75);
            ruleconditionreference66.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity20.Condition = ruleconditionreference66;
            this.ifElseBranchActivity20.Name = "ifElseBranchActivity20";
            // 
            // ifElseBranchActivity19
            // 
            this.ifElseBranchActivity19.Activities.Add(this.logToHistoryListActivity73);
            this.ifElseBranchActivity19.Activities.Add(this.agmPoliceReviewTask);
            this.ifElseBranchActivity19.Activities.Add(this.sendEmailAGMPoliceAdmin);
            this.ifElseBranchActivity19.Activities.Add(this.logToHistoryListActivity74);
            this.ifElseBranchActivity19.Activities.Add(this.whileAGMPoliceReviewTaskIsNOTComplete);
            this.ifElseBranchActivity19.Activities.Add(this.agmPoliceReviewTaskCompleted);
            this.ifElseBranchActivity19.Activities.Add(this.logToHistoryListActivity77);
            this.ifElseBranchActivity19.Activities.Add(this.CAGforAGMPoliceReviewTask);
            ruleconditionreference67.ConditionName = "Check if AGM-Police review required";
            this.ifElseBranchActivity19.Condition = ruleconditionreference67;
            this.ifElseBranchActivity19.Name = "ifElseBranchActivity19";
            // 
            // ifElseBranchActivity16
            // 
            this.ifElseBranchActivity16.Activities.Add(this.logToHistoryListActivity66);
            ruleconditionreference68.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity16.Condition = ruleconditionreference68;
            this.ifElseBranchActivity16.Name = "ifElseBranchActivity16";
            // 
            // ifElseBranchActivity14
            // 
            this.ifElseBranchActivity14.Activities.Add(this.logToHistoryListActivity64);
            this.ifElseBranchActivity14.Activities.Add(this.agmCommunicationsReviewTask);
            this.ifElseBranchActivity14.Activities.Add(this.sendEmailAGMCommunicationsAdmin);
            this.ifElseBranchActivity14.Activities.Add(this.logToHistoryListActivity65);
            this.ifElseBranchActivity14.Activities.Add(this.whileAGMCommunicationsTaskIsNOTComplete);
            this.ifElseBranchActivity14.Activities.Add(this.agmCommunicationsTaskCompleted);
            this.ifElseBranchActivity14.Activities.Add(this.logToHistoryListActivity68);
            this.ifElseBranchActivity14.Activities.Add(this.CAGforAGMCommunicationsReviewTask);
            ruleconditionreference69.ConditionName = "Check if AGM-Communications Review Required";
            this.ifElseBranchActivity14.Condition = ruleconditionreference69;
            this.ifElseBranchActivity14.Name = "ifElseBranchActivity14";
            // 
            // ifElseBranchActivity18
            // 
            this.ifElseBranchActivity18.Activities.Add(this.logToHistoryListActivity57);
            ruleconditionreference70.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity18.Condition = ruleconditionreference70;
            this.ifElseBranchActivity18.Name = "ifElseBranchActivity18";
            // 
            // ifElseBranchActivity17
            // 
            this.ifElseBranchActivity17.Activities.Add(this.logToHistoryListActivity55);
            this.ifElseBranchActivity17.Activities.Add(this.agmAuditReviewTask);
            this.ifElseBranchActivity17.Activities.Add(this.sendEmailAGMAudit);
            this.ifElseBranchActivity17.Activities.Add(this.logToHistoryListActivity56);
            this.ifElseBranchActivity17.Activities.Add(this.whileAGMAuditReviewTaskIsNotComplete);
            this.ifElseBranchActivity17.Activities.Add(this.agmAuditReviewTaskCompleted);
            this.ifElseBranchActivity17.Activities.Add(this.logToHistoryListActivity59);
            this.ifElseBranchActivity17.Activities.Add(this.CAGforAGMAuditReviewTask);
            ruleconditionreference71.ConditionName = "Check if AGM-Audit review required";
            this.ifElseBranchActivity17.Condition = ruleconditionreference71;
            this.ifElseBranchActivity17.Name = "ifElseBranchActivity17";
            // 
            // ifElseBranchActivity11
            // 
            this.ifElseBranchActivity11.Activities.Add(this.logToHistoryListActivity48);
            ruleconditionreference72.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity11.Condition = ruleconditionreference72;
            this.ifElseBranchActivity11.Name = "ifElseBranchActivity11";
            // 
            // ifElseBranchActivity10
            // 
            this.ifElseBranchActivity10.Activities.Add(this.logToHistoryListActivity46);
            this.ifElseBranchActivity10.Activities.Add(this.agmContractsReviewTask);
            this.ifElseBranchActivity10.Activities.Add(this.sendEmailAGMContracts);
            this.ifElseBranchActivity10.Activities.Add(this.logToHistoryListActivity47);
            this.ifElseBranchActivity10.Activities.Add(this.whileAGMContractsReviewIsNOTComplete);
            this.ifElseBranchActivity10.Activities.Add(this.agmContractsReviewTaskCompleted);
            this.ifElseBranchActivity10.Activities.Add(this.logToHistoryListActivity50);
            this.ifElseBranchActivity10.Activities.Add(this.CAGforAGMContractsReviewTask);
            ruleconditionreference73.ConditionName = "Check if AGM-Contracts review required";
            this.ifElseBranchActivity10.Condition = ruleconditionreference73;
            this.ifElseBranchActivity10.Name = "ifElseBranchActivity10";
            // 
            // ifElseBranchActivity13
            // 
            this.ifElseBranchActivity13.Activities.Add(this.logToHistoryListActivity39);
            ruleconditionreference74.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity13.Condition = ruleconditionreference74;
            this.ifElseBranchActivity13.Name = "ifElseBranchActivity13";
            // 
            // ifElseBranchActivity12
            // 
            this.ifElseBranchActivity12.Activities.Add(this.logToHistoryListActivity37);
            this.ifElseBranchActivity12.Activities.Add(this.agmLegalReviewTask);
            this.ifElseBranchActivity12.Activities.Add(this.sendEmailAGMLegalAdmin);
            this.ifElseBranchActivity12.Activities.Add(this.logToHistoryListActivity38);
            this.ifElseBranchActivity12.Activities.Add(this.whileAGMLegalReviewIsNotComplete);
            this.ifElseBranchActivity12.Activities.Add(this.agmLegalReviewTaskCompleted);
            this.ifElseBranchActivity12.Activities.Add(this.logToHistoryListActivity41);
            this.ifElseBranchActivity12.Activities.Add(this.CAGforAGMLegalReviewTask);
            ruleconditionreference75.ConditionName = "Check if AGM-Legal review required";
            this.ifElseBranchActivity12.Condition = ruleconditionreference75;
            this.ifElseBranchActivity12.Name = "ifElseBranchActivity12";
            // 
            // ifElseBranchActivity7
            // 
            this.ifElseBranchActivity7.Activities.Add(this.logToHistoryListActivity30);
            ruleconditionreference76.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity7.Condition = ruleconditionreference76;
            this.ifElseBranchActivity7.Name = "ifElseBranchActivity7";
            // 
            // ifElseBranchActivity6
            // 
            this.ifElseBranchActivity6.Activities.Add(this.logToHistoryListActivity28);
            this.ifElseBranchActivity6.Activities.Add(this.agmSafetyReviewTask);
            this.ifElseBranchActivity6.Activities.Add(this.sendEmailAGMSafetyAdmin);
            this.ifElseBranchActivity6.Activities.Add(this.logToHistoryListActivity29);
            this.ifElseBranchActivity6.Activities.Add(this.whileAGMSafetyReviewIsNotComplete);
            this.ifElseBranchActivity6.Activities.Add(this.agmSafetyReviewTaskCompleted);
            this.ifElseBranchActivity6.Activities.Add(this.logToHistoryListActivity32);
            this.ifElseBranchActivity6.Activities.Add(this.CAGForSafetyReviewTask);
            ruleconditionreference77.ConditionName = "Check if AGM-Safety review required";
            this.ifElseBranchActivity6.Condition = ruleconditionreference77;
            this.ifElseBranchActivity6.Name = "ifElseBranchActivity6";
            // 
            // ifElseBranchActivity9
            // 
            this.ifElseBranchActivity9.Activities.Add(this.logToHistoryListActivity21);
            ruleconditionreference78.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity9.Condition = ruleconditionreference78;
            this.ifElseBranchActivity9.Name = "ifElseBranchActivity9";
            // 
            // ifElseBranchActivity8
            // 
            this.ifElseBranchActivity8.Activities.Add(this.logToHistoryListActivity19);
            this.ifElseBranchActivity8.Activities.Add(this.agmHumanResourcesReviewTask);
            this.ifElseBranchActivity8.Activities.Add(this.sendEmailHumanResourcesAdmin);
            this.ifElseBranchActivity8.Activities.Add(this.logToHistoryListActivity20);
            this.ifElseBranchActivity8.Activities.Add(this.whileAGMHumanResourcesTaskNotComplete);
            this.ifElseBranchActivity8.Activities.Add(this.agmHumanResourcesReviewTaskCompleted);
            this.ifElseBranchActivity8.Activities.Add(this.logToHistoryListActivity23);
            this.ifElseBranchActivity8.Activities.Add(this.CAGForAGMHumanResourcesReviewTask);
            ruleconditionreference79.ConditionName = "Check if AGM-Human Resource Review required.";
            this.ifElseBranchActivity8.Condition = ruleconditionreference79;
            this.ifElseBranchActivity8.Name = "ifElseBranchActivity8";
            // 
            // ifElseBranchActivity5
            // 
            this.ifElseBranchActivity5.Activities.Add(this.logToHistoryListActivity12);
            ruleconditionreference80.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity5.Condition = ruleconditionreference80;
            this.ifElseBranchActivity5.Name = "ifElseBranchActivity5";
            // 
            // ifElseBranchActivity4
            // 
            this.ifElseBranchActivity4.Activities.Add(this.logToHistoryListActivity10);
            this.ifElseBranchActivity4.Activities.Add(this.agmPlanningReviewTask);
            this.ifElseBranchActivity4.Activities.Add(this.sendEmailAGMPlanningAdmin);
            this.ifElseBranchActivity4.Activities.Add(this.logToHistoryListActivity11);
            this.ifElseBranchActivity4.Activities.Add(this.whileAGMPlanningReviewTaskNotComplete);
            this.ifElseBranchActivity4.Activities.Add(this.agmPlanningReviewTaskCompleted);
            this.ifElseBranchActivity4.Activities.Add(this.logToHistoryListActivity14);
            this.ifElseBranchActivity4.Activities.Add(this.CAGForAGMPlanningReviewTask);
            ruleconditionreference81.ConditionName = "Check if AGM-Planning review required";
            this.ifElseBranchActivity4.Condition = ruleconditionreference81;
            this.ifElseBranchActivity4.Name = "ifElseBranchActivity4";
            // 
            // ifElseBranchActivity3
            // 
            this.ifElseBranchActivity3.Activities.Add(this.logToHistoryListActivity3);
            ruleconditionreference82.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity3.Condition = ruleconditionreference82;
            this.ifElseBranchActivity3.Name = "ifElseBranchActivity3";
            // 
            // ifElseBranchActivity1
            // 
            this.ifElseBranchActivity1.Activities.Add(this.logToHistoryListActivity1);
            this.ifElseBranchActivity1.Activities.Add(this.agmITReviewTask);
            this.ifElseBranchActivity1.Activities.Add(this.sendEmailAGMITAdmin);
            this.ifElseBranchActivity1.Activities.Add(this.logToHistoryListActivity2);
            this.ifElseBranchActivity1.Activities.Add(this.whileAGMITReviewIsNotComplete);
            this.ifElseBranchActivity1.Activities.Add(this.agmITReviewTaskCompleted);
            this.ifElseBranchActivity1.Activities.Add(this.logToHistoryListActivity5);
            this.ifElseBranchActivity1.Activities.Add(this.CAGforAGM_ITReviewTask);
            ruleconditionreference83.ConditionName = "Check if AGM-IT Review required";
            this.ifElseBranchActivity1.Condition = ruleconditionreference83;
            this.ifElseBranchActivity1.Name = "ifElseBranchActivity1";
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Activities.Add(this.logAGMFinanceNotSelected);
            ruleconditionreference84.ConditionName = "If AGM Finance Review not required";
            this.ifElseBranchActivity2.Condition = ruleconditionreference84;
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
            // 
            // ifReviewRequired
            // 
            this.ifReviewRequired.Activities.Add(this.logAGMFinanceSelected);
            this.ifReviewRequired.Activities.Add(this.agmFinanceReviewTask);
            this.ifReviewRequired.Activities.Add(this.sendEmailAGMFinanceAdmin);
            this.ifReviewRequired.Activities.Add(this.logAGMFinanceReviewTaskCreated);
            this.ifReviewRequired.Activities.Add(this.whileAGMFinanceReviewIsNotComplete);
            this.ifReviewRequired.Activities.Add(this.agmFinanceReviewTaskCompleted);
            this.ifReviewRequired.Activities.Add(this.logAGMFinanceReviewTaskCompleted);
            this.ifReviewRequired.Activities.Add(this.CAGforAGMFinanceReviewTask);
            ruleconditionreference85.ConditionName = "Check if AGM-Finance review required";
            this.ifReviewRequired.Condition = ruleconditionreference85;
            this.ifReviewRequired.Name = "ifReviewRequired";
            // 
            // ifElseBranchActivity44
            // 
            this.ifElseBranchActivity44.Activities.Add(this.logToHistoryListActivity147);
            this.ifElseBranchActivity44.Activities.Add(this.delayActivity17);
            this.ifElseBranchActivity44.Activities.Add(this.logToHistoryListActivity148);
            this.ifElseBranchActivity44.Name = "ifElseBranchActivity44";
            // 
            // ifElseBranchActivity43
            // 
            this.ifElseBranchActivity43.Activities.Add(this.updateTask4);
            this.ifElseBranchActivity43.Activities.Add(this.onTaskChanged6);
            this.ifElseBranchActivity43.Activities.Add(this.logToHistoryListActivity146);
            codecondition18.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDGMReviewTaskOverDue);
            this.ifElseBranchActivity43.Condition = codecondition18;
            this.ifElseBranchActivity43.Name = "ifElseBranchActivity43";
            // 
            // ifElseBranchActivity42
            // 
            this.ifElseBranchActivity42.Activities.Add(this.logToHistoryListActivity141);
            this.ifElseBranchActivity42.Activities.Add(this.delayActivity16);
            this.ifElseBranchActivity42.Activities.Add(this.logToHistoryListActivity142);
            this.ifElseBranchActivity42.Name = "ifElseBranchActivity42";
            // 
            // ifElseBranchActivity41
            // 
            this.ifElseBranchActivity41.Activities.Add(this.updateTask3);
            this.ifElseBranchActivity41.Activities.Add(this.onTaskChanged4);
            this.ifElseBranchActivity41.Activities.Add(this.logToHistoryListActivity140);
            codecondition19.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDGMReviewTaskOverDue);
            this.ifElseBranchActivity41.Condition = codecondition19;
            this.ifElseBranchActivity41.Name = "ifElseBranchActivity41";
            // 
            // parallelActivity17
            // 
            this.parallelActivity17.Activities.Add(this.sequenceActivity36);
            this.parallelActivity17.Activities.Add(this.sequenceActivity37);
            this.parallelActivity17.Name = "parallelActivity17";
            // 
            // parallelActivity16
            // 
            this.parallelActivity16.Activities.Add(this.sequenceActivity34);
            this.parallelActivity16.Activities.Add(this.sequenceActivity35);
            this.parallelActivity16.Name = "parallelActivity16";
            // 
            // ifElseAdHocUser3Selected
            // 
            this.ifElseAdHocUser3Selected.Activities.Add(this.ifElseBranchActivity25);
            this.ifElseAdHocUser3Selected.Activities.Add(this.ifElseBranchActivity26);
            this.ifElseAdHocUser3Selected.Description = "IF AdHoc User3 review is required for this document set";
            this.ifElseAdHocUser3Selected.Name = "ifElseAdHocUser3Selected";
            // 
            // ifElseAdHocUser2Selected
            // 
            this.ifElseAdHocUser2Selected.Activities.Add(this.ifElseBranchActivity23);
            this.ifElseAdHocUser2Selected.Activities.Add(this.ifElseBranchActivity24);
            this.ifElseAdHocUser2Selected.Description = "IF AdHoc User2 review is required for this document set";
            this.ifElseAdHocUser2Selected.Name = "ifElseAdHocUser2Selected";
            // 
            // ifElseAdHocUser1Selected
            // 
            this.ifElseAdHocUser1Selected.Activities.Add(this.ifElseBranchActivity21);
            this.ifElseAdHocUser1Selected.Activities.Add(this.ifElseBranchActivity22);
            this.ifElseAdHocUser1Selected.Description = "IF AdHoc User1 review is required for this document set";
            this.ifElseAdHocUser1Selected.Name = "ifElseAdHocUser1Selected";
            // 
            // ifElseAGMPoliceSelected
            // 
            this.ifElseAGMPoliceSelected.Activities.Add(this.ifElseBranchActivity19);
            this.ifElseAGMPoliceSelected.Activities.Add(this.ifElseBranchActivity20);
            this.ifElseAGMPoliceSelected.Description = "IF AGM-Finance review is required for this document set";
            this.ifElseAGMPoliceSelected.Name = "ifElseAGMPoliceSelected";
            // 
            // ifElseAGMCommunicationsSelected
            // 
            this.ifElseAGMCommunicationsSelected.Activities.Add(this.ifElseBranchActivity14);
            this.ifElseAGMCommunicationsSelected.Activities.Add(this.ifElseBranchActivity16);
            this.ifElseAGMCommunicationsSelected.Description = "IF AGM-Communication review is required for this document set";
            this.ifElseAGMCommunicationsSelected.Name = "ifElseAGMCommunicationsSelected";
            // 
            // ifElseAGMAuditSelected
            // 
            this.ifElseAGMAuditSelected.Activities.Add(this.ifElseBranchActivity17);
            this.ifElseAGMAuditSelected.Activities.Add(this.ifElseBranchActivity18);
            this.ifElseAGMAuditSelected.Description = "IF AGM-Audit review is required for this document set";
            this.ifElseAGMAuditSelected.Name = "ifElseAGMAuditSelected";
            // 
            // ifElseAGMContractsSelected
            // 
            this.ifElseAGMContractsSelected.Activities.Add(this.ifElseBranchActivity10);
            this.ifElseAGMContractsSelected.Activities.Add(this.ifElseBranchActivity11);
            this.ifElseAGMContractsSelected.Description = "IF AGM-Contracts review is required for this document set";
            this.ifElseAGMContractsSelected.Name = "ifElseAGMContractsSelected";
            // 
            // ifElseAGMLegalIsSelected
            // 
            this.ifElseAGMLegalIsSelected.Activities.Add(this.ifElseBranchActivity12);
            this.ifElseAGMLegalIsSelected.Activities.Add(this.ifElseBranchActivity13);
            this.ifElseAGMLegalIsSelected.Description = "IF AGM-Legal review is required for this document set";
            this.ifElseAGMLegalIsSelected.Name = "ifElseAGMLegalIsSelected";
            // 
            // ifElseAGMSafetySelected
            // 
            this.ifElseAGMSafetySelected.Activities.Add(this.ifElseBranchActivity6);
            this.ifElseAGMSafetySelected.Activities.Add(this.ifElseBranchActivity7);
            this.ifElseAGMSafetySelected.Description = "IF AGM-Safety review is required for this document set";
            this.ifElseAGMSafetySelected.Name = "ifElseAGMSafetySelected";
            // 
            // ifElseAGMHumanResourcesReviewRequired
            // 
            this.ifElseAGMHumanResourcesReviewRequired.Activities.Add(this.ifElseBranchActivity8);
            this.ifElseAGMHumanResourcesReviewRequired.Activities.Add(this.ifElseBranchActivity9);
            this.ifElseAGMHumanResourcesReviewRequired.Description = "IF AGM-HumanResources review is required for this document set";
            this.ifElseAGMHumanResourcesReviewRequired.Name = "ifElseAGMHumanResourcesReviewRequired";
            // 
            // ifElseAGMPlanningReviewRequired
            // 
            this.ifElseAGMPlanningReviewRequired.Activities.Add(this.ifElseBranchActivity4);
            this.ifElseAGMPlanningReviewRequired.Activities.Add(this.ifElseBranchActivity5);
            this.ifElseAGMPlanningReviewRequired.Description = "IF AGM-Planning review is required for this document set";
            this.ifElseAGMPlanningReviewRequired.Name = "ifElseAGMPlanningReviewRequired";
            // 
            // ifElseAGM_ITReviewRequired
            // 
            this.ifElseAGM_ITReviewRequired.Activities.Add(this.ifElseBranchActivity1);
            this.ifElseAGM_ITReviewRequired.Activities.Add(this.ifElseBranchActivity3);
            this.ifElseAGM_ITReviewRequired.Description = "IF AGM-IT review is required for this document set";
            this.ifElseAGM_ITReviewRequired.Name = "ifElseAGM_ITReviewRequired";
            // 
            // ifElseAGMFinanceReviewRequired
            // 
            this.ifElseAGMFinanceReviewRequired.Activities.Add(this.ifReviewRequired);
            this.ifElseAGMFinanceReviewRequired.Activities.Add(this.ifElseBranchActivity2);
            this.ifElseAGMFinanceReviewRequired.Description = "IF AGM-Finance review is required for this document set";
            this.ifElseAGMFinanceReviewRequired.Name = "ifElseAGMFinanceReviewRequired";
            // 
            // ifElseActivity17
            // 
            this.ifElseActivity17.Activities.Add(this.ifElseBranchActivity43);
            this.ifElseActivity17.Activities.Add(this.ifElseBranchActivity44);
            this.ifElseActivity17.Name = "ifElseActivity17";
            // 
            // onTaskCreated4
            // 
            activitybind232.Name = "BoardAgendaWorkflow";
            activitybind232.Path = "onDGMReviewTaskCreated_AfterProperties";
            correlationtoken118.Name = "DGMApproveTask";
            correlationtoken118.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskCreated4.CorrelationToken = correlationtoken118;
            this.onTaskCreated4.Executor = null;
            this.onTaskCreated4.Name = "onTaskCreated4";
            activitybind233.Name = "BoardAgendaWorkflow";
            activitybind233.Path = "DGMApproveTask_TaskId";
            this.onTaskCreated4.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskCreated_Invoked);
            this.onTaskCreated4.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind233)));
            this.onTaskCreated4.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind232)));
            // 
            // logToHistoryListActivity145
            // 
            this.logToHistoryListActivity145.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity145.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity145.HistoryDescription = "In DGM Review task Created Sequence";
            this.logToHistoryListActivity145.HistoryOutcome = "";
            this.logToHistoryListActivity145.Name = "logToHistoryListActivity145";
            this.logToHistoryListActivity145.OtherData = "";
            this.logToHistoryListActivity145.UserId = -1;
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity41);
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity42);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // onTaskCreated3
            // 
            activitybind234.Name = "BoardAgendaWorkflow";
            activitybind234.Path = "onDGMReviewTaskCreated_AfterProperties";
            correlationtoken119.Name = "DGMApproveTask";
            correlationtoken119.OwnerActivityName = "BoardAgendaWorkflow";
            this.onTaskCreated3.CorrelationToken = correlationtoken119;
            this.onTaskCreated3.Executor = null;
            this.onTaskCreated3.Name = "onTaskCreated3";
            activitybind235.Name = "BoardAgendaWorkflow";
            activitybind235.Path = "DGMApproveTask_TaskId";
            this.onTaskCreated3.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskCreated_Invoked);
            this.onTaskCreated3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind235)));
            this.onTaskCreated3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind234)));
            // 
            // logToHistoryListActivity139
            // 
            this.logToHistoryListActivity139.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity139.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity139.HistoryDescription = "In DGM Review task Created Sequence";
            this.logToHistoryListActivity139.HistoryOutcome = "";
            this.logToHistoryListActivity139.Name = "logToHistoryListActivity139";
            this.logToHistoryListActivity139.OtherData = "";
            this.logToHistoryListActivity139.UserId = -1;
            // 
            // sequenceActivity33
            // 
            this.sequenceActivity33.Activities.Add(this.parallelActivity17);
            this.sequenceActivity33.Name = "sequenceActivity33";
            // 
            // sequenceActivity32
            // 
            this.sequenceActivity32.Activities.Add(this.parallelActivity16);
            this.sequenceActivity32.Name = "sequenceActivity32";
            // 
            // sequenceActivity31
            // 
            this.sequenceActivity31.Activities.Add(this.ifElseAdHocUser3Selected);
            this.sequenceActivity31.Name = "sequenceActivity31";
            // 
            // sequenceActivity30
            // 
            this.sequenceActivity30.Activities.Add(this.ifElseAdHocUser2Selected);
            this.sequenceActivity30.Name = "sequenceActivity30";
            // 
            // sequenceActivity29
            // 
            this.sequenceActivity29.Activities.Add(this.ifElseAdHocUser1Selected);
            this.sequenceActivity29.Name = "sequenceActivity29";
            // 
            // sequenceActivity28
            // 
            this.sequenceActivity28.Activities.Add(this.ifElseAGMPoliceSelected);
            this.sequenceActivity28.Name = "sequenceActivity28";
            // 
            // sequenceActivity27
            // 
            this.sequenceActivity27.Name = "sequenceActivity27";
            // 
            // sequenceActivity26
            // 
            this.sequenceActivity26.Activities.Add(this.ifElseAGMCommunicationsSelected);
            this.sequenceActivity26.Name = "sequenceActivity26";
            // 
            // sequenceActivity24
            // 
            this.sequenceActivity24.Activities.Add(this.ifElseAGMAuditSelected);
            this.sequenceActivity24.Name = "sequenceActivity24";
            // 
            // sequenceActivity23
            // 
            this.sequenceActivity23.Activities.Add(this.ifElseAGMContractsSelected);
            this.sequenceActivity23.Name = "sequenceActivity23";
            // 
            // sequenceActivity22
            // 
            this.sequenceActivity22.Activities.Add(this.ifElseAGMLegalIsSelected);
            this.sequenceActivity22.Name = "sequenceActivity22";
            // 
            // sequenceActivity21
            // 
            this.sequenceActivity21.Activities.Add(this.ifElseAGMSafetySelected);
            this.sequenceActivity21.Name = "sequenceActivity21";
            // 
            // sequenceActivity20
            // 
            this.sequenceActivity20.Activities.Add(this.ifElseAGMHumanResourcesReviewRequired);
            this.sequenceActivity20.Name = "sequenceActivity20";
            // 
            // sequenceActivity19
            // 
            this.sequenceActivity19.Activities.Add(this.ifElseAGMPlanningReviewRequired);
            this.sequenceActivity19.Name = "sequenceActivity19";
            // 
            // sequenceActivity18
            // 
            this.sequenceActivity18.Activities.Add(this.ifElseAGM_ITReviewRequired);
            this.sequenceActivity18.Name = "sequenceActivity18";
            // 
            // sequenceActivity17
            // 
            this.sequenceActivity17.Activities.Add(this.ifElseAGMFinanceReviewRequired);
            this.sequenceActivity17.Name = "sequenceActivity17";
            // 
            // onCBSSReReviewTaskChanged
            // 
            activitybind236.Name = "BoardAgendaWorkflow";
            activitybind236.Path = "onCBSSReReviewTaskChanged_AfterProperties";
            activitybind237.Name = "BoardAgendaWorkflow";
            activitybind237.Path = "onCBSSReReviewTaskChanged_BeforeProperties";
            correlationtoken120.Name = "ReApproveTaskForCBSS";
            correlationtoken120.OwnerActivityName = "sequenceActivity99";
            this.onCBSSReReviewTaskChanged.CorrelationToken = correlationtoken120;
            this.onCBSSReReviewTaskChanged.Executor = null;
            this.onCBSSReReviewTaskChanged.Name = "onCBSSReReviewTaskChanged";
            activitybind238.Name = "BoardAgendaWorkflow";
            activitybind238.Path = "ReApproveTaskForCBSS_TaskId";
            this.onCBSSReReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSPSSReReviewTaskChanged_Invoked);
            this.onCBSSReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind237)));
            this.onCBSSReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind238)));
            this.onCBSSReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind236)));
            // 
            // onDGMReReviewTaskChanged
            // 
            activitybind239.Name = "BoardAgendaWorkflow";
            activitybind239.Path = "onDGMReReviewTaskChanged_AfterProperties";
            activitybind240.Name = "BoardAgendaWorkflow";
            activitybind240.Path = "onDGMReReviewTaskChanged_BeforeProperties";
            correlationtoken121.Name = "ReApproveTaskForDGM";
            correlationtoken121.OwnerActivityName = "sequenceActivity98";
            this.onDGMReReviewTaskChanged.CorrelationToken = correlationtoken121;
            this.onDGMReReviewTaskChanged.Executor = null;
            this.onDGMReReviewTaskChanged.Name = "onDGMReReviewTaskChanged";
            activitybind241.Name = "BoardAgendaWorkflow";
            activitybind241.Path = "ReApproveTaskForDGM_TaskId";
            this.onDGMReReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReReviewTaskChanged_Invoked);
            this.onDGMReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind240)));
            this.onDGMReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind241)));
            this.onDGMReReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind239)));
            ruleconditionreference86.ConditionName = "Check if DGM Review Task Overdue Sequence should run";
            // 
            // sequenceActivity92
            // 
            this.sequenceActivity92.Activities.Add(this.ifElseActivity17);
            this.sequenceActivity92.Name = "sequenceActivity92";
            this.sequenceActivity92.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference86);
            // 
            // sequenceActivity91
            // 
            this.sequenceActivity91.Name = "sequenceActivity91";
            // 
            // sequenceActivity90
            // 
            this.sequenceActivity90.Activities.Add(this.logToHistoryListActivity145);
            this.sequenceActivity90.Activities.Add(this.onTaskCreated4);
            this.sequenceActivity90.Name = "sequenceActivity90";
            // 
            // onExpeditedCBSSReviewTaskChanged
            // 
            activitybind242.Name = "BoardAgendaWorkflow";
            activitybind242.Path = "onExpeditedCBSSReviewTaskChanged_AfterProperties";
            activitybind243.Name = "BoardAgendaWorkflow";
            activitybind243.Path = "onExpeditedCBSSReviewTaskChanged_BeforeProperties";
            correlationtoken122.Name = "expeditedCBSSReviewTask";
            correlationtoken122.OwnerActivityName = "BoardAgendaWorkflow";
            this.onExpeditedCBSSReviewTaskChanged.CorrelationToken = correlationtoken122;
            this.onExpeditedCBSSReviewTaskChanged.Executor = null;
            this.onExpeditedCBSSReviewTaskChanged.Name = "onExpeditedCBSSReviewTaskChanged";
            activitybind244.Name = "BoardAgendaWorkflow";
            activitybind244.Path = "expeditedCBSSReviewTask_TaskId";
            this.onExpeditedCBSSReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onExpeditedCBSSReviewTaskChanged_Invoked);
            this.onExpeditedCBSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind243)));
            this.onExpeditedCBSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind244)));
            this.onExpeditedCBSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind242)));
            ruleconditionreference87.ConditionName = "Check if DGM Review Task Overdue Sequence should run";
            // 
            // sequenceActivity88
            // 
            this.sequenceActivity88.Activities.Add(this.ifElseActivity1);
            this.sequenceActivity88.Name = "sequenceActivity88";
            this.sequenceActivity88.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference87);
            // 
            // sequenceActivity87
            // 
            this.sequenceActivity87.Name = "sequenceActivity87";
            // 
            // sequenceActivity86
            // 
            this.sequenceActivity86.Activities.Add(this.logToHistoryListActivity139);
            this.sequenceActivity86.Activities.Add(this.onTaskCreated3);
            this.sequenceActivity86.Name = "sequenceActivity86";
            // 
            // onexpeditedDGMReviewTaskChanged
            // 
            activitybind245.Name = "BoardAgendaWorkflow";
            activitybind245.Path = "onexpeditedDGMReviewTaskChanged_AfterProperties";
            activitybind246.Name = "BoardAgendaWorkflow";
            activitybind246.Path = "onexpeditedDGMReviewTaskChanged_BeforeProperties";
            correlationtoken123.Name = "expeditedDGMReviewTask";
            correlationtoken123.OwnerActivityName = "BoardAgendaWorkflow";
            this.onexpeditedDGMReviewTaskChanged.CorrelationToken = correlationtoken123;
            this.onexpeditedDGMReviewTaskChanged.Executor = null;
            this.onexpeditedDGMReviewTaskChanged.Name = "onexpeditedDGMReviewTaskChanged";
            activitybind247.Name = "BoardAgendaWorkflow";
            activitybind247.Path = "expeditedDGMReviewTask_TaskId";
            this.onexpeditedDGMReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onExpeditedDGMReviewTaskChanged_Invoked);
            this.onexpeditedDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind246)));
            this.onexpeditedDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind247)));
            this.onexpeditedDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind245)));
            // 
            // delaySPSSReviewTaskIsDueCheck
            // 
            this.delaySPSSReviewTaskIsDueCheck.Name = "delaySPSSReviewTaskIsDueCheck";
            this.delaySPSSReviewTaskIsDueCheck.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logSPSSReviewTaskExpired
            // 
            this.logSPSSReviewTaskExpired.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logSPSSReviewTaskExpired.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logSPSSReviewTaskExpired.HistoryDescription = "SPSS Review Task set to expired";
            this.logSPSSReviewTaskExpired.HistoryOutcome = "";
            this.logSPSSReviewTaskExpired.Name = "logSPSSReviewTaskExpired";
            this.logSPSSReviewTaskExpired.OtherData = "";
            this.logSPSSReviewTaskExpired.UserId = -1;
            // 
            // onSPSSReviewTaskUpdated
            // 
            activitybind248.Name = "BoardAgendaWorkflow";
            activitybind248.Path = "onSPSSReviewTaskUpdated_AfterProperties";
            activitybind249.Name = "BoardAgendaWorkflow";
            activitybind249.Path = "onSPSSReviewTaskUpdated_BeforeProperties";
            correlationtoken124.Name = "SPSSReviewTask";
            correlationtoken124.OwnerActivityName = "BoardAgendaWorkflow";
            this.onSPSSReviewTaskUpdated.CorrelationToken = correlationtoken124;
            this.onSPSSReviewTaskUpdated.Executor = null;
            this.onSPSSReviewTaskUpdated.Name = "onSPSSReviewTaskUpdated";
            activitybind250.Name = "BoardAgendaWorkflow";
            activitybind250.Path = "SPSSReviewTask_TaskId";
            this.onSPSSReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSPSSReviewTaskUpdated_Invoked);
            this.onSPSSReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind248)));
            this.onSPSSReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind249)));
            this.onSPSSReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind250)));
            // 
            // updateSPSSReviewTaskToExpired
            // 
            this.updateSPSSReviewTaskToExpired.CorrelationToken = correlationtoken124;
            this.updateSPSSReviewTaskToExpired.Name = "updateSPSSReviewTaskToExpired";
            activitybind251.Name = "BoardAgendaWorkflow";
            activitybind251.Path = "SPSSReviewTask_TaskId";
            activitybind252.Name = "BoardAgendaWorkflow";
            activitybind252.Path = "updateSPSSReviewTaskToExpired_TaskProperties";
            this.updateSPSSReviewTaskToExpired.MethodInvoking += new System.EventHandler(this.updateSPSSReviewTaskToExpired_MethodInvoking);
            this.updateSPSSReviewTaskToExpired.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind251)));
            this.updateSPSSReviewTaskToExpired.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind252)));
            // 
            // logDGMReviewTaskDelayAwaken
            // 
            this.logDGMReviewTaskDelayAwaken.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDGMReviewTaskDelayAwaken.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDGMReviewTaskDelayAwaken.HistoryDescription = "DGM Review Task Delay - awakening";
            this.logDGMReviewTaskDelayAwaken.HistoryOutcome = "";
            this.logDGMReviewTaskDelayAwaken.Name = "logDGMReviewTaskDelayAwaken";
            this.logDGMReviewTaskDelayAwaken.OtherData = "";
            this.logDGMReviewTaskDelayAwaken.UserId = -1;
            // 
            // delayAGMApproveTaskIsDueCheck
            // 
            this.delayAGMApproveTaskIsDueCheck.Name = "delayAGMApproveTaskIsDueCheck";
            this.delayAGMApproveTaskIsDueCheck.TimeoutDuration = System.TimeSpan.Parse("00:05:00");
            // 
            // logBeforeDGMReviewTaskDelay
            // 
            this.logBeforeDGMReviewTaskDelay.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logBeforeDGMReviewTaskDelay.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logBeforeDGMReviewTaskDelay.HistoryDescription = "DGM Review Task Delay - sleeping";
            this.logBeforeDGMReviewTaskDelay.HistoryOutcome = "";
            this.logBeforeDGMReviewTaskDelay.Name = "logBeforeDGMReviewTaskDelay";
            this.logBeforeDGMReviewTaskDelay.OtherData = "";
            this.logBeforeDGMReviewTaskDelay.UserId = -1;
            // 
            // logDGMReviewTaskExpired
            // 
            this.logDGMReviewTaskExpired.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDGMReviewTaskExpired.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDGMReviewTaskExpired.HistoryDescription = "DGM Review Task set to expired";
            this.logDGMReviewTaskExpired.HistoryOutcome = "";
            this.logDGMReviewTaskExpired.Name = "logDGMReviewTaskExpired";
            this.logDGMReviewTaskExpired.OtherData = "";
            this.logDGMReviewTaskExpired.UserId = -1;
            // 
            // onDGMReviewTaskUpdated
            // 
            activitybind253.Name = "BoardAgendaWorkflow";
            activitybind253.Path = "onDGMReviewTaskUpdated_AfterProperties";
            activitybind254.Name = "BoardAgendaWorkflow";
            activitybind254.Path = "onDGMReviewTaskUpdated_BeforeProperties";
            correlationtoken125.Name = "DGMApproveTask";
            correlationtoken125.OwnerActivityName = "BoardAgendaWorkflow";
            this.onDGMReviewTaskUpdated.CorrelationToken = correlationtoken125;
            this.onDGMReviewTaskUpdated.Executor = null;
            this.onDGMReviewTaskUpdated.Name = "onDGMReviewTaskUpdated";
            activitybind255.Name = "BoardAgendaWorkflow";
            activitybind255.Path = "DGMApproveTask_TaskId";
            this.onDGMReviewTaskUpdated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskUpdated_Invoked);
            this.onDGMReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind253)));
            this.onDGMReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind254)));
            this.onDGMReviewTaskUpdated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind255)));
            // 
            // updateDGMReviewTaskToExpired
            // 
            this.updateDGMReviewTaskToExpired.CorrelationToken = correlationtoken125;
            this.updateDGMReviewTaskToExpired.Name = "updateDGMReviewTaskToExpired";
            activitybind256.Name = "BoardAgendaWorkflow";
            activitybind256.Path = "DGMApproveTask_TaskId";
            activitybind257.Name = "BoardAgendaWorkflow";
            activitybind257.Path = "updateDGMReviewTaskToExpired_TaskProperties";
            this.updateDGMReviewTaskToExpired.MethodInvoking += new System.EventHandler(this.updateDGMReviewTaskToExpired_MethodInvoking);
            this.updateDGMReviewTaskToExpired.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind256)));
            this.updateDGMReviewTaskToExpired.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind257)));
            // 
            // parallelActivity15
            // 
            this.parallelActivity15.Activities.Add(this.sequenceActivity32);
            this.parallelActivity15.Activities.Add(this.sequenceActivity33);
            this.parallelActivity15.Name = "parallelActivity15";
            // 
            // parallelActivity14
            // 
            this.parallelActivity14.Activities.Add(this.sequenceActivity30);
            this.parallelActivity14.Activities.Add(this.sequenceActivity31);
            this.parallelActivity14.Name = "parallelActivity14";
            // 
            // parallelActivity13
            // 
            this.parallelActivity13.Activities.Add(this.sequenceActivity28);
            this.parallelActivity13.Activities.Add(this.sequenceActivity29);
            this.parallelActivity13.Name = "parallelActivity13";
            // 
            // parallelActivity12
            // 
            this.parallelActivity12.Activities.Add(this.sequenceActivity26);
            this.parallelActivity12.Activities.Add(this.sequenceActivity27);
            this.parallelActivity12.Name = "parallelActivity12";
            // 
            // parallelActivity11
            // 
            this.parallelActivity11.Activities.Add(this.sequenceActivity23);
            this.parallelActivity11.Activities.Add(this.sequenceActivity24);
            this.parallelActivity11.Name = "parallelActivity11";
            // 
            // parallelActivity10
            // 
            this.parallelActivity10.Activities.Add(this.sequenceActivity21);
            this.parallelActivity10.Activities.Add(this.sequenceActivity22);
            this.parallelActivity10.Name = "parallelActivity10";
            // 
            // parallelActivity9
            // 
            this.parallelActivity9.Activities.Add(this.sequenceActivity19);
            this.parallelActivity9.Activities.Add(this.sequenceActivity20);
            this.parallelActivity9.Name = "parallelActivity9";
            // 
            // parallelActivity8
            // 
            this.parallelActivity8.Activities.Add(this.sequenceActivity17);
            this.parallelActivity8.Activities.Add(this.sequenceActivity18);
            this.parallelActivity8.Name = "parallelActivity8";
            // 
            // onGMReApproveTaskChanged
            // 
            activitybind258.Name = "BoardAgendaWorkflow";
            activitybind258.Path = "onGMReApproveTaskChanged_AfterProperties";
            activitybind259.Name = "BoardAgendaWorkflow";
            activitybind259.Path = "onGMReApproveTaskChanged_BeforeProperties";
            correlationtoken126.Name = "GMReApproveTask";
            correlationtoken126.OwnerActivityName = "sequenceActivity100";
            this.onGMReApproveTaskChanged.CorrelationToken = correlationtoken126;
            this.onGMReApproveTaskChanged.Executor = null;
            this.onGMReApproveTaskChanged.Name = "onGMReApproveTaskChanged";
            activitybind260.Name = "BoardAgendaWorkflow";
            activitybind260.Path = "GMReApproveTask_TaskId";
            this.onGMReApproveTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onGMReApproveTaskChanged_Invoked);
            this.onGMReApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind260)));
            this.onGMReApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind258)));
            this.onGMReApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind259)));
            // 
            // logToHistoryListActivity163
            // 
            this.logToHistoryListActivity163.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity163.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity163.HistoryDescription = "SPSS Review Task Completed";
            this.logToHistoryListActivity163.HistoryOutcome = "";
            this.logToHistoryListActivity163.Name = "logToHistoryListActivity163";
            this.logToHistoryListActivity163.OtherData = "";
            this.logToHistoryListActivity163.UserId = -1;
            // 
            // completeCBSSReReviewTask
            // 
            this.completeCBSSReReviewTask.CorrelationToken = correlationtoken120;
            this.completeCBSSReReviewTask.Name = "completeCBSSReReviewTask";
            activitybind261.Name = "BoardAgendaWorkflow";
            activitybind261.Path = "ReApproveTaskForCBSS_TaskId";
            this.completeCBSSReReviewTask.TaskOutcome = null;
            this.completeCBSSReReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind261)));
            // 
            // whileActivity4
            // 
            this.whileActivity4.Activities.Add(this.onCBSSReReviewTaskChanged);
            ruleconditionreference88.ConditionName = "SPSS Re-Review Task is NOT complete";
            this.whileActivity4.Condition = ruleconditionreference88;
            this.whileActivity4.Name = "whileActivity4";
            // 
            // logToHistoryListActivity162
            // 
            this.logToHistoryListActivity162.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity162.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity162.HistoryDescription = "SPSS Re-Review Task Created";
            this.logToHistoryListActivity162.HistoryOutcome = "";
            this.logToHistoryListActivity162.Name = "logToHistoryListActivity162";
            this.logToHistoryListActivity162.OtherData = "";
            this.logToHistoryListActivity162.UserId = -1;
            // 
            // sendEmail2
            // 
            this.sendEmail2.BCC = null;
            this.sendEmail2.Body = null;
            this.sendEmail2.CC = null;
            correlationtoken127.Name = "workflowToken";
            correlationtoken127.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmail2.CorrelationToken = correlationtoken127;
            this.sendEmail2.From = null;
            this.sendEmail2.Headers = null;
            this.sendEmail2.IncludeStatus = false;
            this.sendEmail2.Name = "sendEmail2";
            this.sendEmail2.Subject = null;
            this.sendEmail2.To = null;
            this.sendEmail2.MethodInvoking += new System.EventHandler(this.sendCBSSReApproveTaskEmail_MethodInvoking);
            // 
            // ReApproveTaskForCBSS
            // 
            this.ReApproveTaskForCBSS.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.ReApproveTaskForCBSS.CorrelationToken = correlationtoken120;
            this.ReApproveTaskForCBSS.ListItemId = -1;
            this.ReApproveTaskForCBSS.Name = "ReApproveTaskForCBSS";
            this.ReApproveTaskForCBSS.SpecialPermissions = null;
            activitybind262.Name = "BoardAgendaWorkflow";
            activitybind262.Path = "ReApproveTaskForCBSS_TaskId";
            activitybind263.Name = "BoardAgendaWorkflow";
            activitybind263.Path = "ReApproveTaskForCBSS_TaskProperties";
            this.ReApproveTaskForCBSS.MethodInvoking += new System.EventHandler(this.SPSSReReviewTask_MethodInvoking);
            this.ReApproveTaskForCBSS.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind263)));
            this.ReApproveTaskForCBSS.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind262)));
            // 
            // logToHistoryListActivity161
            // 
            this.logToHistoryListActivity161.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity161.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity161.HistoryDescription = "DGM Re-Review Task Completed";
            this.logToHistoryListActivity161.HistoryOutcome = "";
            this.logToHistoryListActivity161.Name = "logToHistoryListActivity161";
            this.logToHistoryListActivity161.OtherData = "";
            this.logToHistoryListActivity161.UserId = -1;
            // 
            // completeDGMReReviewTask
            // 
            this.completeDGMReReviewTask.CorrelationToken = correlationtoken121;
            this.completeDGMReReviewTask.Name = "completeDGMReReviewTask";
            activitybind264.Name = "BoardAgendaWorkflow";
            activitybind264.Path = "ReApproveTaskForDGM_TaskId";
            this.completeDGMReReviewTask.TaskOutcome = null;
            this.completeDGMReReviewTask.MethodInvoking += new System.EventHandler(this.completeDGMReReviewTask_MethodInvoking);
            this.completeDGMReReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind264)));
            // 
            // whileActivity3
            // 
            this.whileActivity3.Activities.Add(this.onDGMReReviewTaskChanged);
            ruleconditionreference89.ConditionName = "DGM Re-Review Task is NOT Complete";
            this.whileActivity3.Condition = ruleconditionreference89;
            this.whileActivity3.Name = "whileActivity3";
            // 
            // logToHistoryListActivity160
            // 
            this.logToHistoryListActivity160.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity160.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity160.HistoryDescription = "DGM Re-Review Task Created";
            this.logToHistoryListActivity160.HistoryOutcome = "";
            this.logToHistoryListActivity160.Name = "logToHistoryListActivity160";
            this.logToHistoryListActivity160.OtherData = "";
            this.logToHistoryListActivity160.UserId = -1;
            // 
            // sendEmail1
            // 
            this.sendEmail1.BCC = null;
            this.sendEmail1.Body = null;
            this.sendEmail1.CC = null;
            correlationtoken128.Name = "workflowToken";
            correlationtoken128.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendEmail1.CorrelationToken = correlationtoken128;
            this.sendEmail1.From = null;
            this.sendEmail1.Headers = null;
            this.sendEmail1.IncludeStatus = false;
            this.sendEmail1.Name = "sendEmail1";
            this.sendEmail1.Subject = null;
            this.sendEmail1.To = null;
            this.sendEmail1.MethodInvoking += new System.EventHandler(this.sendDGMReApproveTaskEmail_MethodInvoking);
            // 
            // ReApproveTaskForDGM
            // 
            this.ReApproveTaskForDGM.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.ReApproveTaskForDGM.CorrelationToken = correlationtoken121;
            this.ReApproveTaskForDGM.ListItemId = -1;
            this.ReApproveTaskForDGM.Name = "ReApproveTaskForDGM";
            this.ReApproveTaskForDGM.SpecialPermissions = null;
            activitybind265.Name = "BoardAgendaWorkflow";
            activitybind265.Path = "ReApproveTaskForDGM_TaskId";
            activitybind266.Name = "BoardAgendaWorkflow";
            activitybind266.Path = "ReApproveTaskForDGM_TaskProperties";
            this.ReApproveTaskForDGM.MethodInvoking += new System.EventHandler(this.ReApproveTaskForDGM_MethodInvoking);
            this.ReApproveTaskForDGM.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind266)));
            this.ReApproveTaskForDGM.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind265)));
            // 
            // conditionedActivityGroup4
            // 
            this.conditionedActivityGroup4.Activities.Add(this.sequenceActivity90);
            this.conditionedActivityGroup4.Activities.Add(this.sequenceActivity91);
            this.conditionedActivityGroup4.Activities.Add(this.sequenceActivity92);
            this.conditionedActivityGroup4.Enabled = false;
            this.conditionedActivityGroup4.Name = "conditionedActivityGroup4";
            ruleconditionreference90.ConditionName = "DGM Review Task is Complete";
            this.conditionedActivityGroup4.UntilCondition = ruleconditionreference90;
            // 
            // logToHistoryListActivity144
            // 
            this.logToHistoryListActivity144.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity144.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity144.HistoryDescription = "Expedited CBSS Review Task Completed";
            this.logToHistoryListActivity144.HistoryOutcome = "";
            this.logToHistoryListActivity144.Name = "logToHistoryListActivity144";
            this.logToHistoryListActivity144.OtherData = "";
            this.logToHistoryListActivity144.UserId = -1;
            // 
            // expeditedCBSSReviewTaskCompleted
            // 
            this.expeditedCBSSReviewTaskCompleted.CorrelationToken = correlationtoken122;
            this.expeditedCBSSReviewTaskCompleted.Name = "expeditedCBSSReviewTaskCompleted";
            activitybind267.Name = "BoardAgendaWorkflow";
            activitybind267.Path = "expeditedCBSSReviewTask_TaskId";
            this.expeditedCBSSReviewTaskCompleted.TaskOutcome = null;
            this.expeditedCBSSReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind267)));
            // 
            // whileCBSSReviewTaskIsNOTComplete
            // 
            this.whileCBSSReviewTaskIsNOTComplete.Activities.Add(this.onExpeditedCBSSReviewTaskChanged);
            ruleconditionreference91.ConditionName = "Expedited CBSS Review Task is NOT complete";
            this.whileCBSSReviewTaskIsNOTComplete.Condition = ruleconditionreference91;
            this.whileCBSSReviewTaskIsNOTComplete.Name = "whileCBSSReviewTaskIsNOTComplete";
            // 
            // logToHistoryListActivity143
            // 
            this.logToHistoryListActivity143.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity143.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity143.HistoryDescription = "Expedited CBSS Review Task Created";
            this.logToHistoryListActivity143.HistoryOutcome = "";
            this.logToHistoryListActivity143.Name = "logToHistoryListActivity143";
            this.logToHistoryListActivity143.OtherData = "";
            this.logToHistoryListActivity143.UserId = -1;
            // 
            // expeditedCBSSReviewTask
            // 
            this.expeditedCBSSReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.expeditedCBSSReviewTask.CorrelationToken = correlationtoken122;
            this.expeditedCBSSReviewTask.ListItemId = -1;
            this.expeditedCBSSReviewTask.Name = "expeditedCBSSReviewTask";
            this.expeditedCBSSReviewTask.SpecialPermissions = null;
            activitybind268.Name = "BoardAgendaWorkflow";
            activitybind268.Path = "expeditedCBSSReviewTask_TaskId";
            activitybind269.Name = "BoardAgendaWorkflow";
            activitybind269.Path = "expeditedCBSSReviewTask_TaskProperties";
            this.expeditedCBSSReviewTask.MethodInvoking += new System.EventHandler(this.ExpeditedCBSSApproveTask_MethodInvoking);
            this.expeditedCBSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind269)));
            this.expeditedCBSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind268)));
            // 
            // conditionedActivityGroup3
            // 
            this.conditionedActivityGroup3.Activities.Add(this.sequenceActivity86);
            this.conditionedActivityGroup3.Activities.Add(this.sequenceActivity87);
            this.conditionedActivityGroup3.Activities.Add(this.sequenceActivity88);
            this.conditionedActivityGroup3.Enabled = false;
            this.conditionedActivityGroup3.Name = "conditionedActivityGroup3";
            ruleconditionreference92.ConditionName = "DGM Review Task is Complete";
            this.conditionedActivityGroup3.UntilCondition = ruleconditionreference92;
            // 
            // logToHistoryListActivity138
            // 
            this.logToHistoryListActivity138.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity138.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity138.HistoryDescription = "Expedited DGM Review Task Completed";
            this.logToHistoryListActivity138.HistoryOutcome = "";
            this.logToHistoryListActivity138.Name = "logToHistoryListActivity138";
            this.logToHistoryListActivity138.OtherData = "";
            this.logToHistoryListActivity138.UserId = -1;
            // 
            // expeditedDGMReviewTaskCompleted
            // 
            this.expeditedDGMReviewTaskCompleted.CorrelationToken = correlationtoken123;
            this.expeditedDGMReviewTaskCompleted.Name = "expeditedDGMReviewTaskCompleted";
            activitybind270.Name = "BoardAgendaWorkflow";
            activitybind270.Path = "expeditedDGMReviewTask_TaskId";
            this.expeditedDGMReviewTaskCompleted.TaskOutcome = null;
            this.expeditedDGMReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind270)));
            // 
            // whileDGMReviewTaskNotComplete
            // 
            this.whileDGMReviewTaskNotComplete.Activities.Add(this.onexpeditedDGMReviewTaskChanged);
            ruleconditionreference93.ConditionName = "Expedited DGM Review is NOT complete";
            this.whileDGMReviewTaskNotComplete.Condition = ruleconditionreference93;
            this.whileDGMReviewTaskNotComplete.Name = "whileDGMReviewTaskNotComplete";
            // 
            // logToHistoryListActivity137
            // 
            this.logToHistoryListActivity137.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity137.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity137.HistoryDescription = "DGM Review Task Created (Expedited Workflow)";
            this.logToHistoryListActivity137.HistoryOutcome = "";
            this.logToHistoryListActivity137.Name = "logToHistoryListActivity137";
            this.logToHistoryListActivity137.OtherData = "";
            this.logToHistoryListActivity137.UserId = -1;
            // 
            // expeditedDGMReviewTask
            // 
            this.expeditedDGMReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.expeditedDGMReviewTask.CorrelationToken = correlationtoken123;
            this.expeditedDGMReviewTask.ListItemId = -1;
            this.expeditedDGMReviewTask.Name = "expeditedDGMReviewTask";
            this.expeditedDGMReviewTask.SpecialPermissions = null;
            activitybind271.Name = "BoardAgendaWorkflow";
            activitybind271.Path = "expeditedDGMReviewTask_TaskId";
            activitybind272.Name = "BoardAgendaWorkflow";
            activitybind272.Path = "expeditedDGMReviewTask_TaskProperties";
            this.expeditedDGMReviewTask.MethodInvoking += new System.EventHandler(this.ExpeditedDGMReviewTask_MethodInvoking);
            this.expeditedDGMReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind272)));
            this.expeditedDGMReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind271)));
            // 
            // SPSSReviewTaskIsNotOverdue
            // 
            this.SPSSReviewTaskIsNotOverdue.Activities.Add(this.delaySPSSReviewTaskIsDueCheck);
            this.SPSSReviewTaskIsNotOverdue.Name = "SPSSReviewTaskIsNotOverdue";
            // 
            // SPSSReviewTaskIsOverdue
            // 
            this.SPSSReviewTaskIsOverdue.Activities.Add(this.updateSPSSReviewTaskToExpired);
            this.SPSSReviewTaskIsOverdue.Activities.Add(this.onSPSSReviewTaskUpdated);
            this.SPSSReviewTaskIsOverdue.Activities.Add(this.logSPSSReviewTaskExpired);
            codecondition20.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsSPSSReviewTaskOverDue);
            this.SPSSReviewTaskIsOverdue.Condition = codecondition20;
            this.SPSSReviewTaskIsOverdue.Name = "SPSSReviewTaskIsOverdue";
            // 
            // DGMReviewTaskIsNotOverdue
            // 
            this.DGMReviewTaskIsNotOverdue.Activities.Add(this.logBeforeDGMReviewTaskDelay);
            this.DGMReviewTaskIsNotOverdue.Activities.Add(this.delayAGMApproveTaskIsDueCheck);
            this.DGMReviewTaskIsNotOverdue.Activities.Add(this.logDGMReviewTaskDelayAwaken);
            this.DGMReviewTaskIsNotOverdue.Name = "DGMReviewTaskIsNotOverdue";
            // 
            // DGMReviewTaskIsOverDue
            // 
            this.DGMReviewTaskIsOverDue.Activities.Add(this.updateDGMReviewTaskToExpired);
            this.DGMReviewTaskIsOverDue.Activities.Add(this.onDGMReviewTaskUpdated);
            this.DGMReviewTaskIsOverDue.Activities.Add(this.logDGMReviewTaskExpired);
            codecondition21.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDGMReviewTaskOverDue);
            this.DGMReviewTaskIsOverDue.Condition = codecondition21;
            this.DGMReviewTaskIsOverDue.Name = "DGMReviewTaskIsOverDue";
            // 
            // sequenceActivity16
            // 
            this.sequenceActivity16.Activities.Add(this.parallelActivity15);
            this.sequenceActivity16.Name = "sequenceActivity16";
            // 
            // sequenceActivity15
            // 
            this.sequenceActivity15.Activities.Add(this.parallelActivity14);
            this.sequenceActivity15.Name = "sequenceActivity15";
            // 
            // sequenceActivity14
            // 
            this.sequenceActivity14.Activities.Add(this.parallelActivity13);
            this.sequenceActivity14.Name = "sequenceActivity14";
            // 
            // sequenceActivity13
            // 
            this.sequenceActivity13.Activities.Add(this.parallelActivity12);
            this.sequenceActivity13.Name = "sequenceActivity13";
            // 
            // sequenceActivity12
            // 
            this.sequenceActivity12.Activities.Add(this.parallelActivity11);
            this.sequenceActivity12.Name = "sequenceActivity12";
            // 
            // sequenceActivity11
            // 
            this.sequenceActivity11.Activities.Add(this.parallelActivity10);
            this.sequenceActivity11.Name = "sequenceActivity11";
            // 
            // sequenceActivity10
            // 
            this.sequenceActivity10.Activities.Add(this.parallelActivity9);
            this.sequenceActivity10.Name = "sequenceActivity10";
            // 
            // sequenceActivity9
            // 
            this.sequenceActivity9.Activities.Add(this.parallelActivity8);
            this.sequenceActivity9.Name = "sequenceActivity9";
            // 
            // completeGMReApproveTask
            // 
            this.completeGMReApproveTask.CorrelationToken = correlationtoken126;
            this.completeGMReApproveTask.Name = "completeGMReApproveTask";
            activitybind273.Name = "BoardAgendaWorkflow";
            activitybind273.Path = "GMReApproveTask_TaskId";
            this.completeGMReApproveTask.TaskOutcome = null;
            this.completeGMReApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind273)));
            // 
            // whileGMReApproveTaskIsNotComplete
            // 
            this.whileGMReApproveTaskIsNotComplete.Activities.Add(this.onGMReApproveTaskChanged);
            ruleconditionreference94.ConditionName = "While GM Reapprove Task is NOT Complete";
            this.whileGMReApproveTaskIsNotComplete.Condition = ruleconditionreference94;
            this.whileGMReApproveTaskIsNotComplete.Name = "whileGMReApproveTaskIsNotComplete";
            // 
            // logToHistoryListActivity165
            // 
            this.logToHistoryListActivity165.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity165.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity165.HistoryDescription = "";
            this.logToHistoryListActivity165.HistoryOutcome = "";
            this.logToHistoryListActivity165.Name = "logToHistoryListActivity165";
            this.logToHistoryListActivity165.OtherData = "";
            this.logToHistoryListActivity165.UserId = -1;
            // 
            // GMReApproveTask
            // 
            this.GMReApproveTask.ContentTypeId = "0x01080100ee39a4dc829143a3a6d1957f02784526";
            this.GMReApproveTask.CorrelationToken = correlationtoken126;
            this.GMReApproveTask.ListItemId = -1;
            this.GMReApproveTask.Name = "GMReApproveTask";
            this.GMReApproveTask.SpecialPermissions = null;
            activitybind274.Name = "BoardAgendaWorkflow";
            activitybind274.Path = "GMReApproveTask_TaskId";
            activitybind275.Name = "BoardAgendaWorkflow";
            activitybind275.Path = "GMReApproveTask_TaskProperties";
            this.GMReApproveTask.MethodInvoking += new System.EventHandler(this.GMReApproveTask_MethodInvoking);
            this.GMReApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind274)));
            this.GMReApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind275)));
            // 
            // sequenceActivity99
            // 
            this.sequenceActivity99.Activities.Add(this.ReApproveTaskForCBSS);
            this.sequenceActivity99.Activities.Add(this.sendEmail2);
            this.sequenceActivity99.Activities.Add(this.logToHistoryListActivity162);
            this.sequenceActivity99.Activities.Add(this.whileActivity4);
            this.sequenceActivity99.Activities.Add(this.completeCBSSReReviewTask);
            this.sequenceActivity99.Activities.Add(this.logToHistoryListActivity163);
            this.sequenceActivity99.Name = "sequenceActivity99";
            // 
            // sequenceActivity98
            // 
            this.sequenceActivity98.Activities.Add(this.ReApproveTaskForDGM);
            this.sequenceActivity98.Activities.Add(this.sendEmail1);
            this.sequenceActivity98.Activities.Add(this.logToHistoryListActivity160);
            this.sequenceActivity98.Activities.Add(this.whileActivity3);
            this.sequenceActivity98.Activities.Add(this.completeDGMReReviewTask);
            this.sequenceActivity98.Activities.Add(this.logToHistoryListActivity161);
            this.sequenceActivity98.Name = "sequenceActivity98";
            // 
            // logToHistoryListActivity150
            // 
            this.logToHistoryListActivity150.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity150.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity150.HistoryDescription = "CBSS Not selected for Expedited Workflow";
            this.logToHistoryListActivity150.HistoryOutcome = "";
            this.logToHistoryListActivity150.Name = "logToHistoryListActivity150";
            this.logToHistoryListActivity150.OtherData = "";
            this.logToHistoryListActivity150.UserId = -1;
            // 
            // sequenceActivity89
            // 
            this.sequenceActivity89.Activities.Add(this.expeditedCBSSReviewTask);
            this.sequenceActivity89.Activities.Add(this.logToHistoryListActivity143);
            this.sequenceActivity89.Activities.Add(this.whileCBSSReviewTaskIsNOTComplete);
            this.sequenceActivity89.Activities.Add(this.expeditedCBSSReviewTaskCompleted);
            this.sequenceActivity89.Activities.Add(this.logToHistoryListActivity144);
            this.sequenceActivity89.Activities.Add(this.conditionedActivityGroup4);
            this.sequenceActivity89.Name = "sequenceActivity89";
            // 
            // logToHistoryListActivity149
            // 
            this.logToHistoryListActivity149.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity149.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity149.HistoryDescription = "DGM Not selected for Expedited Workflow";
            this.logToHistoryListActivity149.HistoryOutcome = "";
            this.logToHistoryListActivity149.Name = "logToHistoryListActivity149";
            this.logToHistoryListActivity149.OtherData = "";
            this.logToHistoryListActivity149.UserId = -1;
            // 
            // sequenceActivity85
            // 
            this.sequenceActivity85.Activities.Add(this.expeditedDGMReviewTask);
            this.sequenceActivity85.Activities.Add(this.logToHistoryListActivity137);
            this.sequenceActivity85.Activities.Add(this.whileDGMReviewTaskNotComplete);
            this.sequenceActivity85.Activities.Add(this.expeditedDGMReviewTaskCompleted);
            this.sequenceActivity85.Activities.Add(this.logToHistoryListActivity138);
            this.sequenceActivity85.Activities.Add(this.conditionedActivityGroup3);
            this.sequenceActivity85.Name = "sequenceActivity85";
            // 
            // ifElseSPSSReviewTaskIsOverdue
            // 
            this.ifElseSPSSReviewTaskIsOverdue.Activities.Add(this.SPSSReviewTaskIsOverdue);
            this.ifElseSPSSReviewTaskIsOverdue.Activities.Add(this.SPSSReviewTaskIsNotOverdue);
            this.ifElseSPSSReviewTaskIsOverdue.Name = "ifElseSPSSReviewTaskIsOverdue";
            // 
            // onSPSSReviewTaskCreated
            // 
            activitybind276.Name = "BoardAgendaWorkflow";
            activitybind276.Path = "onSPSSReviewTaskCreated_AfterProperties";
            this.onSPSSReviewTaskCreated.CorrelationToken = correlationtoken124;
            this.onSPSSReviewTaskCreated.Executor = null;
            this.onSPSSReviewTaskCreated.Name = "onSPSSReviewTaskCreated";
            activitybind277.Name = "BoardAgendaWorkflow";
            activitybind277.Path = "SPSSReviewTask_TaskId";
            this.onSPSSReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSPSSReviewTaskCreated_Invoked);
            this.onSPSSReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind277)));
            this.onSPSSReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind276)));
            // 
            // logInSPSSReviewTaskCreatedSequence
            // 
            this.logInSPSSReviewTaskCreatedSequence.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logInSPSSReviewTaskCreatedSequence.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logInSPSSReviewTaskCreatedSequence.HistoryDescription = "In SPSS Review Task Created Sequence";
            this.logInSPSSReviewTaskCreatedSequence.HistoryOutcome = "";
            this.logInSPSSReviewTaskCreatedSequence.Name = "logInSPSSReviewTaskCreatedSequence";
            this.logInSPSSReviewTaskCreatedSequence.OtherData = "";
            this.logInSPSSReviewTaskCreatedSequence.UserId = -1;
            // 
            // ifElseDGMReviewTaskIsOverDue
            // 
            this.ifElseDGMReviewTaskIsOverDue.Activities.Add(this.DGMReviewTaskIsOverDue);
            this.ifElseDGMReviewTaskIsOverDue.Activities.Add(this.DGMReviewTaskIsNotOverdue);
            this.ifElseDGMReviewTaskIsOverDue.Name = "ifElseDGMReviewTaskIsOverDue";
            // 
            // onDGMReviewTaskCreated
            // 
            activitybind278.Name = "BoardAgendaWorkflow";
            activitybind278.Path = "onDGMReviewTaskCreated_AfterProperties";
            this.onDGMReviewTaskCreated.CorrelationToken = correlationtoken125;
            this.onDGMReviewTaskCreated.Executor = null;
            this.onDGMReviewTaskCreated.Name = "onDGMReviewTaskCreated";
            activitybind279.Name = "BoardAgendaWorkflow";
            activitybind279.Path = "DGMApproveTask_TaskId";
            this.onDGMReviewTaskCreated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskCreated_Invoked);
            this.onDGMReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind279)));
            this.onDGMReviewTaskCreated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskCreated.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind278)));
            // 
            // logInDGMReviewTaskSequence
            // 
            this.logInDGMReviewTaskSequence.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logInDGMReviewTaskSequence.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logInDGMReviewTaskSequence.HistoryDescription = "In DGM Review task Created Sequence";
            this.logInDGMReviewTaskSequence.HistoryOutcome = "";
            this.logInDGMReviewTaskSequence.Name = "logInDGMReviewTaskSequence";
            this.logInDGMReviewTaskSequence.OtherData = "";
            this.logInDGMReviewTaskSequence.UserId = -1;
            // 
            // parallelActivity7
            // 
            this.parallelActivity7.Activities.Add(this.sequenceActivity15);
            this.parallelActivity7.Activities.Add(this.sequenceActivity16);
            this.parallelActivity7.Name = "parallelActivity7";
            // 
            // parallelActivity6
            // 
            this.parallelActivity6.Activities.Add(this.sequenceActivity13);
            this.parallelActivity6.Activities.Add(this.sequenceActivity14);
            this.parallelActivity6.Name = "parallelActivity6";
            // 
            // parallelActivity5
            // 
            this.parallelActivity5.Activities.Add(this.sequenceActivity11);
            this.parallelActivity5.Activities.Add(this.sequenceActivity12);
            this.parallelActivity5.Name = "parallelActivity5";
            // 
            // parallelActivity4
            // 
            this.parallelActivity4.Activities.Add(this.sequenceActivity9);
            this.parallelActivity4.Activities.Add(this.sequenceActivity10);
            this.parallelActivity4.Name = "parallelActivity4";
            // 
            // logToHistoryListActivity164
            // 
            this.logToHistoryListActivity164.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity164.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity164.HistoryDescription = "GM has approved Task. No need to loop back and send for re-reviews to DGM and CBS" +
                "S";
            this.logToHistoryListActivity164.HistoryOutcome = "";
            this.logToHistoryListActivity164.Name = "logToHistoryListActivity164";
            this.logToHistoryListActivity164.OtherData = "";
            this.logToHistoryListActivity164.UserId = -1;
            // 
            // sequenceActivity100
            // 
            this.sequenceActivity100.Activities.Add(this.GMReApproveTask);
            this.sequenceActivity100.Activities.Add(this.logToHistoryListActivity165);
            this.sequenceActivity100.Activities.Add(this.whileGMReApproveTaskIsNotComplete);
            this.sequenceActivity100.Activities.Add(this.completeGMReApproveTask);
            this.sequenceActivity100.Name = "sequenceActivity100";
            // 
            // parallelActivity19
            // 
            this.parallelActivity19.Activities.Add(this.sequenceActivity98);
            this.parallelActivity19.Activities.Add(this.sequenceActivity99);
            this.parallelActivity19.Name = "parallelActivity19";
            // 
            // notifyAgendaOwnerAboutComments
            // 
            this.notifyAgendaOwnerAboutComments.Action = null;
            this.notifyAgendaOwnerAboutComments.Name = "notifyAgendaOwnerAboutComments";
            this.notifyAgendaOwnerAboutComments.Source = null;
            this.notifyAgendaOwnerAboutComments.TaskAssignedTo = null;
            this.notifyAgendaOwnerAboutComments.TaskDescription = null;
            this.notifyAgendaOwnerAboutComments.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyAgendaOwnerAboutComments.TaskTitle = null;
            // 
            // codeInitializeAgendaOwnerTask
            // 
            this.codeInitializeAgendaOwnerTask.Name = "codeInitializeAgendaOwnerTask";
            this.codeInitializeAgendaOwnerTask.ExecuteCode += new System.EventHandler(this.codeInitializeAgendaOwnerTask_ExecuteCode);
            // 
            // ifElseCBSSNotSelected
            // 
            this.ifElseCBSSNotSelected.Activities.Add(this.logToHistoryListActivity150);
            this.ifElseCBSSNotSelected.Name = "ifElseCBSSNotSelected";
            // 
            // ifElseCBSSSelected
            // 
            this.ifElseCBSSSelected.Activities.Add(this.sequenceActivity89);
            ruleconditionreference95.ConditionName = "Check if CBSS Selected for Expedited WF";
            this.ifElseCBSSSelected.Condition = ruleconditionreference95;
            this.ifElseCBSSSelected.Name = "ifElseCBSSSelected";
            // 
            // ifElseDGMNOTSelected
            // 
            this.ifElseDGMNOTSelected.Activities.Add(this.logToHistoryListActivity149);
            this.ifElseDGMNOTSelected.Name = "ifElseDGMNOTSelected";
            // 
            // ifElseDGMSelected
            // 
            this.ifElseDGMSelected.Activities.Add(this.sequenceActivity85);
            ruleconditionreference96.ConditionName = "Exedited WF - DGM Selected";
            this.ifElseDGMSelected.Condition = ruleconditionreference96;
            this.ifElseDGMSelected.Name = "ifElseDGMSelected";
            ruleconditionreference97.ConditionName = "Check for SPSS Review Task Overdue Sequence";
            // 
            // sequenceSPSSReviewTaskDelay
            // 
            this.sequenceSPSSReviewTaskDelay.Activities.Add(this.ifElseSPSSReviewTaskIsOverdue);
            this.sequenceSPSSReviewTaskDelay.Name = "sequenceSPSSReviewTaskDelay";
            this.sequenceSPSSReviewTaskDelay.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference97);
            // 
            // sequenceSPSSReviewTaskCompleted
            // 
            this.sequenceSPSSReviewTaskCompleted.Name = "sequenceSPSSReviewTaskCompleted";
            // 
            // sequenceSPSSReviewTaskCreated
            // 
            this.sequenceSPSSReviewTaskCreated.Activities.Add(this.logInSPSSReviewTaskCreatedSequence);
            this.sequenceSPSSReviewTaskCreated.Activities.Add(this.onSPSSReviewTaskCreated);
            this.sequenceSPSSReviewTaskCreated.Name = "sequenceSPSSReviewTaskCreated";
            // 
            // onSPSSReviewTaskChanged
            // 
            activitybind280.Name = "BoardAgendaWorkflow";
            activitybind280.Path = "onSPSSReviewTaskChanged_AfterProperties";
            activitybind281.Name = "BoardAgendaWorkflow";
            activitybind281.Path = "onSPSSReviewTaskChanged_BeforeProperties";
            this.onSPSSReviewTaskChanged.CorrelationToken = correlationtoken124;
            this.onSPSSReviewTaskChanged.Executor = null;
            this.onSPSSReviewTaskChanged.Name = "onSPSSReviewTaskChanged";
            activitybind282.Name = "BoardAgendaWorkflow";
            activitybind282.Path = "SPSSReviewTask_TaskId";
            this.onSPSSReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSPSSReviewTaskChanged_Invoked);
            this.onSPSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind280)));
            this.onSPSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind281)));
            this.onSPSSReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind282)));
            ruleconditionreference98.ConditionName = "Check if DGM Review Task Overdue Sequence should run";
            // 
            // sequenceDGMApproveTaskOverdue
            // 
            this.sequenceDGMApproveTaskOverdue.Activities.Add(this.ifElseDGMReviewTaskIsOverDue);
            this.sequenceDGMApproveTaskOverdue.Name = "sequenceDGMApproveTaskOverdue";
            this.sequenceDGMApproveTaskOverdue.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference98);
            // 
            // sequenceDGMReviewTaskCompleted
            // 
            this.sequenceDGMReviewTaskCompleted.Name = "sequenceDGMReviewTaskCompleted";
            // 
            // sequenceDGMReviewTaskCreated
            // 
            this.sequenceDGMReviewTaskCreated.Activities.Add(this.logInDGMReviewTaskSequence);
            this.sequenceDGMReviewTaskCreated.Activities.Add(this.onDGMReviewTaskCreated);
            this.sequenceDGMReviewTaskCreated.Name = "sequenceDGMReviewTaskCreated";
            // 
            // onDGMReviewTaskChanged
            // 
            activitybind283.Name = "BoardAgendaWorkflow";
            activitybind283.Path = "onDGMReviewTaskChanged_AfterProperties";
            activitybind284.Name = "BoardAgendaWorkflow";
            activitybind284.Path = "onDGMReviewTaskChanged_BeforeProperties";
            this.onDGMReviewTaskChanged.CorrelationToken = correlationtoken125;
            this.onDGMReviewTaskChanged.Executor = null;
            this.onDGMReviewTaskChanged.Name = "onDGMReviewTaskChanged";
            activitybind285.Name = "BoardAgendaWorkflow";
            activitybind285.Path = "DGMApproveTask_TaskId";
            this.onDGMReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onDGMReviewTaskChanged_Invoked);
            this.onDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind285)));
            this.onDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind283)));
            this.onDGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind284)));
            // 
            // sequenceActivity8
            // 
            this.sequenceActivity8.Activities.Add(this.parallelActivity7);
            this.sequenceActivity8.Name = "sequenceActivity8";
            // 
            // sequenceActivity7
            // 
            this.sequenceActivity7.Activities.Add(this.parallelActivity6);
            this.sequenceActivity7.Name = "sequenceActivity7";
            // 
            // sequenceActivity6
            // 
            this.sequenceActivity6.Activities.Add(this.parallelActivity5);
            this.sequenceActivity6.Name = "sequenceActivity6";
            // 
            // sequenceActivity5
            // 
            this.sequenceActivity5.Activities.Add(this.parallelActivity4);
            this.sequenceActivity5.Name = "sequenceActivity5";
            // 
            // ifElseBranchActivity46
            // 
            this.ifElseBranchActivity46.Activities.Add(this.logToHistoryListActivity164);
            this.ifElseBranchActivity46.Name = "ifElseBranchActivity46";
            // 
            // ifElseBranchActivity45
            // 
            this.ifElseBranchActivity45.Activities.Add(this.codeInitializeAgendaOwnerTask);
            this.ifElseBranchActivity45.Activities.Add(this.notifyAgendaOwnerAboutComments);
            this.ifElseBranchActivity45.Activities.Add(this.parallelActivity19);
            this.ifElseBranchActivity45.Activities.Add(this.sequenceActivity100);
            ruleconditionreference99.ConditionName = "While GM Task is NOT approved";
            this.ifElseBranchActivity45.Condition = ruleconditionreference99;
            this.ifElseBranchActivity45.Name = "ifElseBranchActivity45";
            // 
            // ifElseExpeditedCBSS
            // 
            this.ifElseExpeditedCBSS.Activities.Add(this.ifElseCBSSSelected);
            this.ifElseExpeditedCBSS.Activities.Add(this.ifElseCBSSNotSelected);
            this.ifElseExpeditedCBSS.Name = "ifElseExpeditedCBSS";
            // 
            // ifElseExpeditedDGM
            // 
            this.ifElseExpeditedDGM.Activities.Add(this.ifElseDGMSelected);
            this.ifElseExpeditedDGM.Activities.Add(this.ifElseDGMNOTSelected);
            this.ifElseExpeditedDGM.Name = "ifElseExpeditedDGM";
            // 
            // CAGForSPSSReviewTask
            // 
            this.CAGForSPSSReviewTask.Activities.Add(this.sequenceSPSSReviewTaskCreated);
            this.CAGForSPSSReviewTask.Activities.Add(this.sequenceSPSSReviewTaskCompleted);
            this.CAGForSPSSReviewTask.Activities.Add(this.sequenceSPSSReviewTaskDelay);
            this.CAGForSPSSReviewTask.Enabled = false;
            this.CAGForSPSSReviewTask.Name = "CAGForSPSSReviewTask";
            ruleconditionreference100.ConditionName = "SPSS Review Task IS  Complete";
            this.CAGForSPSSReviewTask.UntilCondition = ruleconditionreference100;
            // 
            // logSPSSReviewTaskCompleted
            // 
            this.logSPSSReviewTaskCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logSPSSReviewTaskCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logSPSSReviewTaskCompleted.HistoryDescription = "SPSS Review Task Completed";
            this.logSPSSReviewTaskCompleted.HistoryOutcome = "";
            this.logSPSSReviewTaskCompleted.Name = "logSPSSReviewTaskCompleted";
            this.logSPSSReviewTaskCompleted.OtherData = "";
            this.logSPSSReviewTaskCompleted.UserId = -1;
            // 
            // SPSSReviewTaskCompleted
            // 
            this.SPSSReviewTaskCompleted.CorrelationToken = correlationtoken124;
            this.SPSSReviewTaskCompleted.Name = "SPSSReviewTaskCompleted";
            activitybind286.Name = "BoardAgendaWorkflow";
            activitybind286.Path = "SPSSReviewTask_TaskId";
            this.SPSSReviewTaskCompleted.TaskOutcome = null;
            this.SPSSReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind286)));
            // 
            // whileSPSSReviewTaskNotComplted
            // 
            this.whileSPSSReviewTaskNotComplted.Activities.Add(this.onSPSSReviewTaskChanged);
            ruleconditionreference101.ConditionName = "SPSS Review Task is NOT complete";
            this.whileSPSSReviewTaskNotComplted.Condition = ruleconditionreference101;
            this.whileSPSSReviewTaskNotComplted.Name = "whileSPSSReviewTaskNotComplted";
            // 
            // logSPSSReviewTaskCreated
            // 
            this.logSPSSReviewTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logSPSSReviewTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logSPSSReviewTaskCreated.HistoryDescription = "SPSS Review Task Created";
            this.logSPSSReviewTaskCreated.HistoryOutcome = "";
            this.logSPSSReviewTaskCreated.Name = "logSPSSReviewTaskCreated";
            this.logSPSSReviewTaskCreated.OtherData = "";
            this.logSPSSReviewTaskCreated.UserId = -1;
            // 
            // sendCBSSApproveTaskEmail
            // 
            this.sendCBSSApproveTaskEmail.BCC = null;
            this.sendCBSSApproveTaskEmail.Body = null;
            this.sendCBSSApproveTaskEmail.CC = null;
            correlationtoken129.Name = "workflowToken";
            correlationtoken129.OwnerActivityName = "BoardAgendaWorkflow";
            this.sendCBSSApproveTaskEmail.CorrelationToken = correlationtoken129;
            this.sendCBSSApproveTaskEmail.From = null;
            this.sendCBSSApproveTaskEmail.Headers = null;
            this.sendCBSSApproveTaskEmail.IncludeStatus = false;
            this.sendCBSSApproveTaskEmail.Name = "sendCBSSApproveTaskEmail";
            this.sendCBSSApproveTaskEmail.Subject = null;
            this.sendCBSSApproveTaskEmail.To = null;
            this.sendCBSSApproveTaskEmail.MethodInvoking += new System.EventHandler(this.sendCBSSApproveTaskEmail_MethodInvoking);
            // 
            // SPSSReviewTask
            // 
            this.SPSSReviewTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.SPSSReviewTask.CorrelationToken = correlationtoken124;
            this.SPSSReviewTask.ListItemId = -1;
            this.SPSSReviewTask.Name = "SPSSReviewTask";
            this.SPSSReviewTask.SpecialPermissions = null;
            activitybind287.Name = "BoardAgendaWorkflow";
            activitybind287.Path = "SPSSReviewTask_TaskId";
            activitybind288.Name = "BoardAgendaWorkflow";
            activitybind288.Path = "SPSSReviewTask_TaskProperties";
            this.SPSSReviewTask.MethodInvoking += new System.EventHandler(this.SPSSReviewTask_MethodInvoking);
            this.SPSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind287)));
            this.SPSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind288)));
            // 
            // CAGForDGMApproveTask
            // 
            this.CAGForDGMApproveTask.Activities.Add(this.sequenceDGMReviewTaskCreated);
            this.CAGForDGMApproveTask.Activities.Add(this.sequenceDGMReviewTaskCompleted);
            this.CAGForDGMApproveTask.Activities.Add(this.sequenceDGMApproveTaskOverdue);
            this.CAGForDGMApproveTask.Enabled = false;
            this.CAGForDGMApproveTask.Name = "CAGForDGMApproveTask";
            ruleconditionreference102.ConditionName = "DGM Review Task is Complete";
            this.CAGForDGMApproveTask.UntilCondition = ruleconditionreference102;
            // 
            // logDGMReviewTaskCompleted
            // 
            this.logDGMReviewTaskCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDGMReviewTaskCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDGMReviewTaskCompleted.HistoryDescription = "DGM Review Task Completed";
            this.logDGMReviewTaskCompleted.HistoryOutcome = "";
            this.logDGMReviewTaskCompleted.Name = "logDGMReviewTaskCompleted";
            this.logDGMReviewTaskCompleted.OtherData = "";
            this.logDGMReviewTaskCompleted.UserId = -1;
            // 
            // DGMReviewTaskCompleted
            // 
            this.DGMReviewTaskCompleted.CorrelationToken = correlationtoken125;
            this.DGMReviewTaskCompleted.Name = "DGMReviewTaskCompleted";
            activitybind289.Name = "BoardAgendaWorkflow";
            activitybind289.Path = "DGMApproveTask_TaskId";
            this.DGMReviewTaskCompleted.TaskOutcome = null;
            this.DGMReviewTaskCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind289)));
            // 
            // whileAGMReviewTaskNotCompleted
            // 
            this.whileAGMReviewTaskNotCompleted.Activities.Add(this.onDGMReviewTaskChanged);
            ruleconditionreference103.ConditionName = "DGM Review Task is NOT Complete";
            this.whileAGMReviewTaskNotCompleted.Condition = ruleconditionreference103;
            this.whileAGMReviewTaskNotCompleted.Name = "whileAGMReviewTaskNotCompleted";
            // 
            // logDGMReviewTaskCreated
            // 
            this.logDGMReviewTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDGMReviewTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDGMReviewTaskCreated.HistoryDescription = "DGM Review Task Created";
            this.logDGMReviewTaskCreated.HistoryOutcome = "";
            this.logDGMReviewTaskCreated.Name = "logDGMReviewTaskCreated";
            this.logDGMReviewTaskCreated.OtherData = "";
            this.logDGMReviewTaskCreated.UserId = -1;
            // 
            // sendDGMApproveTaskEmail
            // 
            this.sendDGMApproveTaskEmail.BCC = null;
            this.sendDGMApproveTaskEmail.Body = null;
            this.sendDGMApproveTaskEmail.CC = null;
            this.sendDGMApproveTaskEmail.CorrelationToken = correlationtoken129;
            this.sendDGMApproveTaskEmail.From = null;
            this.sendDGMApproveTaskEmail.Headers = null;
            this.sendDGMApproveTaskEmail.IncludeStatus = false;
            this.sendDGMApproveTaskEmail.Name = "sendDGMApproveTaskEmail";
            this.sendDGMApproveTaskEmail.Subject = null;
            this.sendDGMApproveTaskEmail.To = null;
            this.sendDGMApproveTaskEmail.MethodInvoking += new System.EventHandler(this.sendDGMApproveTaskEmail_MethodInvoking);
            // 
            // DGMApproveTask
            // 
            this.DGMApproveTask.ContentTypeId = "0x010801009e12998413ac4b168e4380533fb8ae0f";
            this.DGMApproveTask.CorrelationToken = correlationtoken125;
            this.DGMApproveTask.ListItemId = -1;
            this.DGMApproveTask.Name = "DGMApproveTask";
            this.DGMApproveTask.SpecialPermissions = null;
            activitybind290.Name = "BoardAgendaWorkflow";
            activitybind290.Path = "DGMApproveTask_TaskId";
            activitybind291.Name = "BoardAgendaWorkflow";
            activitybind291.Path = "DGMApproveTask_TaskProperties";
            this.DGMApproveTask.MethodInvoking += new System.EventHandler(this.DGMApproveTask_MethodInvoking);
            this.DGMApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind290)));
            this.DGMApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind291)));
            // 
            // parallelActivity3
            // 
            this.parallelActivity3.Activities.Add(this.sequenceActivity7);
            this.parallelActivity3.Activities.Add(this.sequenceActivity8);
            this.parallelActivity3.Name = "parallelActivity3";
            // 
            // parallelActivity2
            // 
            this.parallelActivity2.Activities.Add(this.sequenceActivity5);
            this.parallelActivity2.Activities.Add(this.sequenceActivity6);
            this.parallelActivity2.Name = "parallelActivity2";
            // 
            // ifElseActivity18
            // 
            this.ifElseActivity18.Activities.Add(this.ifElseBranchActivity45);
            this.ifElseActivity18.Activities.Add(this.ifElseBranchActivity46);
            this.ifElseActivity18.Name = "ifElseActivity18";
            // 
            // sequenceActivity84
            // 
            this.sequenceActivity84.Activities.Add(this.ifElseExpeditedCBSS);
            this.sequenceActivity84.Name = "sequenceActivity84";
            // 
            // sequenceActivity83
            // 
            this.sequenceActivity83.Activities.Add(this.ifElseExpeditedDGM);
            this.sequenceActivity83.Name = "sequenceActivity83";
            // 
            // onSubmitForGMApprovalTaskChanged
            // 
            activitybind292.Name = "BoardAgendaWorkflow";
            activitybind292.Path = "onSubmitForGMApprovalTaskChanged_AfterProperties";
            activitybind293.Name = "BoardAgendaWorkflow";
            activitybind293.Path = "onSubmitForGMApprovalTaskChanged_BeforeProperties";
            correlationtoken130.Name = "SubmitForGMApprovalTask";
            correlationtoken130.OwnerActivityName = "BoardAgendaWorkflow";
            this.onSubmitForGMApprovalTaskChanged.CorrelationToken = correlationtoken130;
            this.onSubmitForGMApprovalTaskChanged.Executor = null;
            this.onSubmitForGMApprovalTaskChanged.Name = "onSubmitForGMApprovalTaskChanged";
            activitybind294.Name = "BoardAgendaWorkflow";
            activitybind294.Path = "SubmitForGMApprovalTask_TaskId";
            this.onSubmitForGMApprovalTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSubmitForGMApprovalTaskChanged_Invoked);
            this.onSubmitForGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind292)));
            this.onSubmitForGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind293)));
            this.onSubmitForGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind294)));
            // 
            // sequenceActivity2
            // 
            this.sequenceActivity2.Activities.Add(this.SPSSReviewTask);
            this.sequenceActivity2.Activities.Add(this.sendCBSSApproveTaskEmail);
            this.sequenceActivity2.Activities.Add(this.logSPSSReviewTaskCreated);
            this.sequenceActivity2.Activities.Add(this.whileSPSSReviewTaskNotComplted);
            this.sequenceActivity2.Activities.Add(this.SPSSReviewTaskCompleted);
            this.sequenceActivity2.Activities.Add(this.logSPSSReviewTaskCompleted);
            this.sequenceActivity2.Activities.Add(this.CAGForSPSSReviewTask);
            this.sequenceActivity2.Name = "sequenceActivity2";
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.DGMApproveTask);
            this.sequenceActivity1.Activities.Add(this.sendDGMApproveTaskEmail);
            this.sequenceActivity1.Activities.Add(this.logDGMReviewTaskCreated);
            this.sequenceActivity1.Activities.Add(this.whileAGMReviewTaskNotCompleted);
            this.sequenceActivity1.Activities.Add(this.DGMReviewTaskCompleted);
            this.sequenceActivity1.Activities.Add(this.logDGMReviewTaskCompleted);
            this.sequenceActivity1.Activities.Add(this.CAGForDGMApproveTask);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // onSubmitForDGMApprovalTaskChanged
            // 
            activitybind295.Name = "BoardAgendaWorkflow";
            activitybind295.Path = "onSubmitForDGMApprovalTaskChanged_AfterProperties";
            activitybind296.Name = "BoardAgendaWorkflow";
            activitybind296.Path = "onSubmitForDGMApprovalTaskChanged_BeforeProperties";
            correlationtoken131.Name = "SubmitForDGMandSPSSReviewTask";
            correlationtoken131.OwnerActivityName = "BoardAgendaWorkflow";
            this.onSubmitForDGMApprovalTaskChanged.CorrelationToken = correlationtoken131;
            this.onSubmitForDGMApprovalTaskChanged.Executor = null;
            this.onSubmitForDGMApprovalTaskChanged.Name = "onSubmitForDGMApprovalTaskChanged";
            activitybind297.Name = "BoardAgendaWorkflow";
            activitybind297.Path = "SubmitForDGMandSPSSReviewTask_TaskId";
            this.onSubmitForDGMApprovalTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onSubmitForDGMApprovalTaskChanged_Invoked);
            this.onSubmitForDGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind297)));
            this.onSubmitForDGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind295)));
            this.onSubmitForDGMApprovalTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind296)));
            // 
            // sequenceActivity4
            // 
            this.sequenceActivity4.Activities.Add(this.parallelActivity3);
            this.sequenceActivity4.Name = "sequenceActivity4";
            // 
            // sequenceActivity3
            // 
            this.sequenceActivity3.Activities.Add(this.parallelActivity2);
            this.sequenceActivity3.Name = "sequenceActivity3";
            // 
            // sequenceActivity97
            // 
            this.sequenceActivity97.Activities.Add(this.ifElseActivity18);
            this.sequenceActivity97.Name = "sequenceActivity97";
            // 
            // onGMApproveTaskChanged
            // 
            activitybind298.Name = "BoardAgendaWorkflow";
            activitybind298.Path = "onGMApproveTaskChanged_AfterProperties";
            activitybind299.Name = "BoardAgendaWorkflow";
            activitybind299.Path = "onGMApproveTaskChanged_BeforeProperties";
            correlationtoken132.Name = "GMApproveTask";
            correlationtoken132.OwnerActivityName = "BoardAgendaWorkflow";
            this.onGMApproveTaskChanged.CorrelationToken = correlationtoken132;
            this.onGMApproveTaskChanged.Executor = null;
            this.onGMApproveTaskChanged.Name = "onGMApproveTaskChanged";
            activitybind300.Name = "BoardAgendaWorkflow";
            activitybind300.Path = "GMApproveTask_TaskId";
            this.onGMApproveTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onGMApproveTaskChanged_Invoked);
            this.onGMApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind299)));
            this.onGMApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind300)));
            this.onGMApproveTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind298)));
            // 
            // parallelActivity18
            // 
            this.parallelActivity18.Activities.Add(this.sequenceActivity83);
            this.parallelActivity18.Activities.Add(this.sequenceActivity84);
            this.parallelActivity18.Name = "parallelActivity18";
            // 
            // logToHistoryListActivity136
            // 
            this.logToHistoryListActivity136.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity136.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity136.HistoryDescription = "Workflow is being Expedited";
            this.logToHistoryListActivity136.HistoryOutcome = "";
            this.logToHistoryListActivity136.Name = "logToHistoryListActivity136";
            this.logToHistoryListActivity136.OtherData = "";
            this.logToHistoryListActivity136.UserId = -1;
            // 
            // codeSetAgendaToExpeditedWFStarted
            // 
            this.codeSetAgendaToExpeditedWFStarted.Name = "codeSetAgendaToExpeditedWFStarted";
            this.codeSetAgendaToExpeditedWFStarted.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatusExpedited_Invoke);
            // 
            // codeSetAgendaStatusToSubmittedForGMApproval
            // 
            this.codeSetAgendaStatusToSubmittedForGMApproval.Name = "codeSetAgendaStatusToSubmittedForGMApproval";
            this.codeSetAgendaStatusToSubmittedForGMApproval.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatusToSubmittedForGMApproval_ExecuteCode);
            // 
            // logSubmitToGMApprovalTaskComplete
            // 
            this.logSubmitToGMApprovalTaskComplete.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logSubmitToGMApprovalTaskComplete.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logSubmitToGMApprovalTaskComplete.HistoryDescription = "Submit To GM Approval Task Complete";
            this.logSubmitToGMApprovalTaskComplete.HistoryOutcome = "";
            this.logSubmitToGMApprovalTaskComplete.Name = "logSubmitToGMApprovalTaskComplete";
            this.logSubmitToGMApprovalTaskComplete.OtherData = "";
            this.logSubmitToGMApprovalTaskComplete.UserId = -1;
            // 
            // completeSubmtToGMApprovalTask
            // 
            this.completeSubmtToGMApprovalTask.CorrelationToken = correlationtoken130;
            this.completeSubmtToGMApprovalTask.Name = "completeSubmtToGMApprovalTask";
            activitybind301.Name = "BoardAgendaWorkflow";
            activitybind301.Path = "SubmitForGMApprovalTask_TaskId";
            this.completeSubmtToGMApprovalTask.TaskOutcome = null;
            this.completeSubmtToGMApprovalTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind301)));
            // 
            // whileSubmitToGMApprovalTaskIsNotComplete
            // 
            this.whileSubmitToGMApprovalTaskIsNotComplete.Activities.Add(this.onSubmitForGMApprovalTaskChanged);
            ruleconditionreference104.ConditionName = "Submit to GM Approve Task IS NOT complete";
            this.whileSubmitToGMApprovalTaskIsNotComplete.Condition = ruleconditionreference104;
            this.whileSubmitToGMApprovalTaskIsNotComplete.Name = "whileSubmitToGMApprovalTaskIsNotComplete";
            // 
            // logGMApprovalTaskCreated
            // 
            this.logGMApprovalTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logGMApprovalTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logGMApprovalTaskCreated.HistoryDescription = "GM Approval Task Created.";
            this.logGMApprovalTaskCreated.HistoryOutcome = "";
            this.logGMApprovalTaskCreated.Name = "logGMApprovalTaskCreated";
            this.logGMApprovalTaskCreated.OtherData = "";
            this.logGMApprovalTaskCreated.UserId = -1;
            // 
            // SubmitForGMApprovalTask
            // 
            this.SubmitForGMApprovalTask.ContentTypeId = "0x01080100e3fda60103d34034a92743ac20255cb2";
            this.SubmitForGMApprovalTask.CorrelationToken = correlationtoken130;
            this.SubmitForGMApprovalTask.ListItemId = -1;
            this.SubmitForGMApprovalTask.Name = "SubmitForGMApprovalTask";
            this.SubmitForGMApprovalTask.SpecialPermissions = null;
            activitybind302.Name = "BoardAgendaWorkflow";
            activitybind302.Path = "SubmitForGMApprovalTask_TaskId";
            activitybind303.Name = "BoardAgendaWorkflow";
            activitybind303.Path = "SubmitForGMApprovalTask_TaskProperties";
            this.SubmitForGMApprovalTask.MethodInvoking += new System.EventHandler(this.SubmitForGMApprovalTask_MethodInvoking);
            this.SubmitForGMApprovalTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind302)));
            this.SubmitForGMApprovalTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind303)));
            // 
            // logAgendaStatusSetToDGMReviewCompleted
            // 
            this.logAgendaStatusSetToDGMReviewCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAgendaStatusSetToDGMReviewCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAgendaStatusSetToDGMReviewCompleted.HistoryDescription = "DGM/SPSS Review completed. Agenda Status Changed.";
            this.logAgendaStatusSetToDGMReviewCompleted.HistoryOutcome = "";
            this.logAgendaStatusSetToDGMReviewCompleted.Name = "logAgendaStatusSetToDGMReviewCompleted";
            this.logAgendaStatusSetToDGMReviewCompleted.OtherData = "";
            this.logAgendaStatusSetToDGMReviewCompleted.UserId = -1;
            // 
            // codeSetAgendaStatusToDGMApproved
            // 
            this.codeSetAgendaStatusToDGMApproved.Name = "codeSetAgendaStatusToDGMApproved";
            this.codeSetAgendaStatusToDGMApproved.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatusToDGMApproved_ExecuteCode);
            // 
            // parallelDGMandSPSSApproval
            // 
            this.parallelDGMandSPSSApproval.Activities.Add(this.sequenceActivity1);
            this.parallelDGMandSPSSApproval.Activities.Add(this.sequenceActivity2);
            this.parallelDGMandSPSSApproval.Enabled = false;
            this.parallelDGMandSPSSApproval.Name = "parallelDGMandSPSSApproval";
            // 
            // logDGMApprovalTaskCompleted
            // 
            this.logDGMApprovalTaskCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDGMApprovalTaskCompleted.Enabled = false;
            this.logDGMApprovalTaskCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDGMApprovalTaskCompleted.HistoryDescription = "Submit For DGM Approval Task Completed";
            this.logDGMApprovalTaskCompleted.HistoryOutcome = "";
            this.logDGMApprovalTaskCompleted.Name = "logDGMApprovalTaskCompleted";
            this.logDGMApprovalTaskCompleted.OtherData = "";
            this.logDGMApprovalTaskCompleted.UserId = -1;
            // 
            // SubmitForDGMApprovalTaskComplete
            // 
            this.SubmitForDGMApprovalTaskComplete.CorrelationToken = correlationtoken131;
            this.SubmitForDGMApprovalTaskComplete.Enabled = false;
            this.SubmitForDGMApprovalTaskComplete.Name = "SubmitForDGMApprovalTaskComplete";
            activitybind304.Name = "BoardAgendaWorkflow";
            activitybind304.Path = "SubmitForDGMandSPSSReviewTask_TaskId";
            this.SubmitForDGMApprovalTaskComplete.TaskOutcome = null;
            this.SubmitForDGMApprovalTaskComplete.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind304)));
            // 
            // whileDGMApprovalTaskIncomplete
            // 
            this.whileDGMApprovalTaskIncomplete.Activities.Add(this.onSubmitForDGMApprovalTaskChanged);
            ruleconditionreference105.ConditionName = "Submit for DGM Approval Task is NOT complete";
            this.whileDGMApprovalTaskIncomplete.Condition = ruleconditionreference105;
            this.whileDGMApprovalTaskIncomplete.Enabled = false;
            this.whileDGMApprovalTaskIncomplete.Name = "whileDGMApprovalTaskIncomplete";
            // 
            // logSubmitForDGMApprovalTaskCreated
            // 
            this.logSubmitForDGMApprovalTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logSubmitForDGMApprovalTaskCreated.Enabled = false;
            this.logSubmitForDGMApprovalTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logSubmitForDGMApprovalTaskCreated.HistoryDescription = "Task for DGM/SPSS approval created";
            this.logSubmitForDGMApprovalTaskCreated.HistoryOutcome = "";
            this.logSubmitForDGMApprovalTaskCreated.Name = "logSubmitForDGMApprovalTaskCreated";
            this.logSubmitForDGMApprovalTaskCreated.OtherData = "";
            this.logSubmitForDGMApprovalTaskCreated.UserId = -1;
            // 
            // SubmitForDGMandSPSSReviewTask
            // 
            this.SubmitForDGMandSPSSReviewTask.ContentTypeId = "0x0108010016c86bf8a3904e258281ce6783920922";
            this.SubmitForDGMandSPSSReviewTask.CorrelationToken = correlationtoken131;
            this.SubmitForDGMandSPSSReviewTask.Description = "Submit for DGM and SPSS Review Task. Task assigned to the Agenda Originator.";
            this.SubmitForDGMandSPSSReviewTask.Enabled = false;
            this.SubmitForDGMandSPSSReviewTask.ListItemId = -1;
            this.SubmitForDGMandSPSSReviewTask.Name = "SubmitForDGMandSPSSReviewTask";
            this.SubmitForDGMandSPSSReviewTask.SpecialPermissions = null;
            activitybind305.Name = "BoardAgendaWorkflow";
            activitybind305.Path = "SubmitForDGMandSPSSReviewTask_TaskId";
            activitybind306.Name = "BoardAgendaWorkflow";
            activitybind306.Path = "SubmitForDGMandSPSSReviewTask_TaskProperties";
            this.SubmitForDGMandSPSSReviewTask.MethodInvoking += new System.EventHandler(this.SubmitForDGMandSPSSReviewTask_MethodInvoking);
            this.SubmitForDGMandSPSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind305)));
            this.SubmitForDGMandSPSSReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind306)));
            // 
            // logAgendaStatusChangedToStakeHolderReviewCompleted
            // 
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.HistoryDescription = "Agenda Status Changed to \'Stake Holder Review Completed\'";
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.HistoryOutcome = "";
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.Name = "logAgendaStatusChangedToStakeHolderReviewCompleted";
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.OtherData = "";
            this.logAgendaStatusChangedToStakeHolderReviewCompleted.UserId = -1;
            // 
            // codeSetAgendaStatusToStakeHolderReviewsComplete
            // 
            this.codeSetAgendaStatusToStakeHolderReviewsComplete.Name = "codeSetAgendaStatusToStakeHolderReviewsComplete";
            this.codeSetAgendaStatusToStakeHolderReviewsComplete.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatusToStakeHolderReviewsComplete_ExecuteCode);
            // 
            // parallelActivity1
            // 
            this.parallelActivity1.Activities.Add(this.sequenceActivity3);
            this.parallelActivity1.Activities.Add(this.sequenceActivity4);
            this.parallelActivity1.Name = "parallelActivity1";
            // 
            // codeSetAgendaStatusToPublished
            // 
            this.codeSetAgendaStatusToPublished.Name = "codeSetAgendaStatusToPublished";
            this.codeSetAgendaStatusToPublished.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatusToPublished_ExecuteCode);
            // 
            // logDocSetCopied
            // 
            this.logDocSetCopied.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logDocSetCopied.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logDocSetCopied.HistoryDescription = "Document Set Ready to be Published to Board Site";
            this.logDocSetCopied.HistoryOutcome = "";
            this.logDocSetCopied.Name = "logDocSetCopied";
            this.logDocSetCopied.OtherData = "";
            this.logDocSetCopied.UserId = -1;
            // 
            // codeCopyDocSetToBoard
            // 
            this.codeCopyDocSetToBoard.Name = "codeCopyDocSetToBoard";
            this.codeCopyDocSetToBoard.ExecuteCode += new System.EventHandler(this.codeCopyDocSetToBoard_ExecuteCode);
            // 
            // logGMApproveTaskCompleted
            // 
            this.logGMApproveTaskCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logGMApproveTaskCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logGMApproveTaskCompleted.HistoryDescription = "GM Approval task marked completed";
            this.logGMApproveTaskCompleted.HistoryOutcome = "";
            this.logGMApproveTaskCompleted.Name = "logGMApproveTaskCompleted";
            this.logGMApproveTaskCompleted.OtherData = "";
            this.logGMApproveTaskCompleted.UserId = -1;
            // 
            // GMApproveTaskComplete
            // 
            correlationtoken133.Name = "GMApproveTask";
            correlationtoken133.OwnerActivityName = "BoardAgendaWorkflow";
            this.GMApproveTaskComplete.CorrelationToken = correlationtoken133;
            this.GMApproveTaskComplete.Name = "GMApproveTaskComplete";
            activitybind307.Name = "BoardAgendaWorkflow";
            activitybind307.Path = "GMApproveTask_TaskId";
            this.GMApproveTaskComplete.TaskOutcome = null;
            this.GMApproveTaskComplete.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind307)));
            // 
            // whileGMApproveTaskIsNotApproved
            // 
            this.whileGMApproveTaskIsNotApproved.Activities.Add(this.sequenceActivity97);
            ruleconditionreference106.ConditionName = "While GM Task is NOT approved";
            this.whileGMApproveTaskIsNotApproved.Condition = ruleconditionreference106;
            this.whileGMApproveTaskIsNotApproved.Name = "whileGMApproveTaskIsNotApproved";
            // 
            // whileGMApproveTaskIsNOTComplete
            // 
            this.whileGMApproveTaskIsNOTComplete.Activities.Add(this.onGMApproveTaskChanged);
            ruleconditionreference107.ConditionName = "GM Approve task is NOT complete";
            this.whileGMApproveTaskIsNOTComplete.Condition = ruleconditionreference107;
            this.whileGMApproveTaskIsNOTComplete.Name = "whileGMApproveTaskIsNOTComplete";
            // 
            // logGMApproveTaskCreated
            // 
            this.logGMApproveTaskCreated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logGMApproveTaskCreated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logGMApproveTaskCreated.HistoryDescription = "GM Approve Task Created";
            this.logGMApproveTaskCreated.HistoryOutcome = "";
            this.logGMApproveTaskCreated.Name = "logGMApproveTaskCreated";
            this.logGMApproveTaskCreated.OtherData = "";
            this.logGMApproveTaskCreated.UserId = -1;
            // 
            // GMApproveTask
            // 
            this.GMApproveTask.ContentTypeId = "0x01080100ee39a4dc829143a3a6d1957f02784526";
            this.GMApproveTask.CorrelationToken = correlationtoken133;
            this.GMApproveTask.ListItemId = -1;
            this.GMApproveTask.Name = "GMApproveTask";
            this.GMApproveTask.SpecialPermissions = null;
            activitybind308.Name = "BoardAgendaWorkflow";
            activitybind308.Path = "GMApproveTask_TaskId";
            activitybind309.Name = "BoardAgendaWorkflow";
            activitybind309.Path = "GMApproveTask_TaskProperties";
            this.GMApproveTask.MethodInvoking += new System.EventHandler(this.GMApproveTask_MethodInvoking);
            this.GMApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind308)));
            this.GMApproveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind309)));
            // 
            // ifExpedited
            // 
            this.ifExpedited.Activities.Add(this.codeSetAgendaToExpeditedWFStarted);
            this.ifExpedited.Activities.Add(this.logToHistoryListActivity136);
            this.ifExpedited.Activities.Add(this.parallelActivity18);
            this.ifExpedited.Name = "ifExpedited";
            // 
            // ifNormal
            // 
            this.ifNormal.Activities.Add(this.parallelActivity1);
            this.ifNormal.Activities.Add(this.codeSetAgendaStatusToStakeHolderReviewsComplete);
            this.ifNormal.Activities.Add(this.logAgendaStatusChangedToStakeHolderReviewCompleted);
            this.ifNormal.Activities.Add(this.SubmitForDGMandSPSSReviewTask);
            this.ifNormal.Activities.Add(this.logSubmitForDGMApprovalTaskCreated);
            this.ifNormal.Activities.Add(this.whileDGMApprovalTaskIncomplete);
            this.ifNormal.Activities.Add(this.SubmitForDGMApprovalTaskComplete);
            this.ifNormal.Activities.Add(this.logDGMApprovalTaskCompleted);
            this.ifNormal.Activities.Add(this.parallelDGMandSPSSApproval);
            this.ifNormal.Activities.Add(this.codeSetAgendaStatusToDGMApproved);
            this.ifNormal.Activities.Add(this.logAgendaStatusSetToDGMReviewCompleted);
            this.ifNormal.Activities.Add(this.SubmitForGMApprovalTask);
            this.ifNormal.Activities.Add(this.logGMApprovalTaskCreated);
            this.ifNormal.Activities.Add(this.whileSubmitToGMApprovalTaskIsNotComplete);
            this.ifNormal.Activities.Add(this.completeSubmtToGMApprovalTask);
            this.ifNormal.Activities.Add(this.logSubmitToGMApprovalTaskComplete);
            this.ifNormal.Activities.Add(this.codeSetAgendaStatusToSubmittedForGMApproval);
            ruleconditionreference108.ConditionName = "If workflow is NOT Expedited (Normal)";
            this.ifNormal.Condition = ruleconditionreference108;
            this.ifNormal.Name = "ifNormal";
            // 
            // notifyAgendaOwner
            // 
            this.notifyAgendaOwner.Action = "Complete";
            this.notifyAgendaOwner.Name = "notifyAgendaOwner";
            this.notifyAgendaOwner.Source = "Paperless Board";
            this.notifyAgendaOwner.TaskAssignedTo = null;
            this.notifyAgendaOwner.TaskDescription = null;
            this.notifyAgendaOwner.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyAgendaOwner.TaskTitle = null;
            // 
            // logWorkflowCompleted
            // 
            this.logWorkflowCompleted.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logWorkflowCompleted.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logWorkflowCompleted.HistoryDescription = "Workflow Completed!";
            this.logWorkflowCompleted.HistoryOutcome = "";
            this.logWorkflowCompleted.Name = "logWorkflowCompleted";
            this.logWorkflowCompleted.OtherData = "";
            this.logWorkflowCompleted.UserId = -1;
            // 
            // sequenceActivity25
            // 
            this.sequenceActivity25.Activities.Add(this.GMApproveTask);
            this.sequenceActivity25.Activities.Add(this.logGMApproveTaskCreated);
            this.sequenceActivity25.Activities.Add(this.whileGMApproveTaskIsNOTComplete);
            this.sequenceActivity25.Activities.Add(this.whileGMApproveTaskIsNotApproved);
            this.sequenceActivity25.Activities.Add(this.GMApproveTaskComplete);
            this.sequenceActivity25.Activities.Add(this.logGMApproveTaskCompleted);
            this.sequenceActivity25.Activities.Add(this.codeCopyDocSetToBoard);
            this.sequenceActivity25.Activities.Add(this.logDocSetCopied);
            this.sequenceActivity25.Activities.Add(this.codeSetAgendaStatusToPublished);
            this.sequenceActivity25.Name = "sequenceActivity25";
            // 
            // ifElseExpedited
            // 
            this.ifElseExpedited.Activities.Add(this.ifNormal);
            this.ifElseExpedited.Activities.Add(this.ifExpedited);
            this.ifElseExpedited.Name = "ifElseExpedited";
            // 
            // sendEmailToCommitteeCoordinators
            // 
            this.sendEmailToCommitteeCoordinators.BCC = null;
            activitybind310.Name = "BoardAgendaWorkflow";
            activitybind310.Path = "sendEmailToCommitteeCoordinators_Body";
            this.sendEmailToCommitteeCoordinators.CC = null;
            this.sendEmailToCommitteeCoordinators.CorrelationToken = correlationtoken129;
            this.sendEmailToCommitteeCoordinators.From = null;
            this.sendEmailToCommitteeCoordinators.Headers = null;
            this.sendEmailToCommitteeCoordinators.IncludeStatus = false;
            this.sendEmailToCommitteeCoordinators.Name = "sendEmailToCommitteeCoordinators";
            activitybind311.Name = "BoardAgendaWorkflow";
            activitybind311.Path = "sendEmailToCommitteeCoordinators_Subject";
            activitybind312.Name = "BoardAgendaWorkflow";
            activitybind312.Path = "sendEmailToCommitteeCoordinators_To";
            this.sendEmailToCommitteeCoordinators.MethodInvoking += new System.EventHandler(this.sendEmailToCommitteeCoordinators_MethodInvoking);
            this.sendEmailToCommitteeCoordinators.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind311)));
            this.sendEmailToCommitteeCoordinators.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind312)));
            this.sendEmailToCommitteeCoordinators.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind310)));
            // 
            // logStatusForAgendaChanged
            // 
            this.logStatusForAgendaChanged.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logStatusForAgendaChanged.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logStatusForAgendaChanged.HistoryDescription = "Status for Agenda Changed to Published to Reviewers";
            this.logStatusForAgendaChanged.HistoryOutcome = "";
            this.logStatusForAgendaChanged.Name = "logStatusForAgendaChanged";
            this.logStatusForAgendaChanged.OtherData = "";
            this.logStatusForAgendaChanged.UserId = -1;
            // 
            // codeSetAgendaStatusToPublishedForReview
            // 
            this.codeSetAgendaStatusToPublishedForReview.Name = "codeSetAgendaStatusToPublishedForReview";
            this.codeSetAgendaStatusToPublishedForReview.ExecuteCode += new System.EventHandler(this.codeSetAgendaStatus_Invoke);
            activitybind314.Name = "BoardAgendaWorkflow";
            activitybind314.Path = "workflowId";
            // 
            // onWorkflowActivated
            // 
            this.onWorkflowActivated.CorrelationToken = correlationtoken129;
            this.onWorkflowActivated.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated.Name = "onWorkflowActivated";
            activitybind313.Name = "BoardAgendaWorkflow";
            activitybind313.Path = "workflowProperties";
            this.onWorkflowActivated.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.OnWorkflowActivated_Invoked);
            this.onWorkflowActivated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind314)));
            this.onWorkflowActivated.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind313)));
            // 
            // BoardAgendaWorkflow
            // 
            this.Activities.Add(this.onWorkflowActivated);
            this.Activities.Add(this.codeSetAgendaStatusToPublishedForReview);
            this.Activities.Add(this.logStatusForAgendaChanged);
            this.Activities.Add(this.sendEmailToCommitteeCoordinators);
            this.Activities.Add(this.ifElseExpedited);
            this.Activities.Add(this.sequenceActivity25);
            this.Activities.Add(this.logWorkflowCompleted);
            this.Activities.Add(this.notifyAgendaOwner);
            this.Name = "BoardAgendaWorkflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private CustomActivities.NotifyAgendaOwner notifyAgendaOwnerAboutComments;

        private CodeActivity codeInitializeAgendaOwnerTask;

        private CustomActivities.NotifyAgendaOwner notifyAgendaOwner;

        private WhileActivity whileGMApproveTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onGMReApproveTaskChanged;

        private WhileActivity whileGMReApproveTaskIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity165;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType GMReApproveTask;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeGMReApproveTask;

        private SequenceActivity sequenceActivity100;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity164;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onCBSSReReviewTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onDGMReReviewTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity163;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeCBSSReReviewTask;

        private WhileActivity whileActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity162;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail2;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType ReApproveTaskForCBSS;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity161;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeDGMReReviewTask;

        private WhileActivity whileActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity160;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail1;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType ReApproveTaskForDGM;

        private SequenceActivity sequenceActivity99;

        private SequenceActivity sequenceActivity98;

        private ParallelActivity parallelActivity19;

        private IfElseBranchActivity ifElseBranchActivity46;

        private IfElseBranchActivity ifElseBranchActivity45;

        private IfElseActivity ifElseActivity18;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onGMApproveTaskChanged;

        private SequenceActivity sequenceActivity97;

        private CodeActivity codeSetAgendaToExpeditedWFStarted;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailExecutiveDirectorAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMRailOpsAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMBusOpsAdmin;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity159;

        private DelayActivity delayActivity18;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity158;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity157;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged5;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateTask5;

        private CodeActivity codeActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity156;

        private IfElseBranchActivity ifElseBranchActivity40;

        private IfElseBranchActivity ifElseBranchActivity39;

        private IfElseActivity ifElseActivity19;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onTaskCreated5;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity155;

        private SequenceActivity sequenceActivity96;

        private SequenceActivity sequenceActivity95;

        private SequenceActivity sequenceActivity94;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onExecutiveDirectorReviewTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity154;

        private ConditionedActivityGroup conditionedActivityGroup5;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity153;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask executiveDirectorReviewTaskCompleted;

        private WhileActivity whileActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity152;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType executiveDirectorReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity151;

        private IfElseBranchActivity ifElseBranchActivity38;

        private IfElseBranchActivity ifElseBranchActivity37;

        private IfElseActivity ifElseExecutiveDirectorSelected;

        private SequenceActivity sequenceActivity93;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailHumanResourcesAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMPlanningAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMITAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMContracts;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMLegalAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMSafetyAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMPoliceAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMCommunicationsAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMAudit;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailAGMFinanceAdmin;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendCBSSApproveTaskEmail;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendDGMApproveTaskEmail;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmailToCommitteeCoordinators;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity142;

        private DelayActivity delayActivity16;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity141;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity140;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged4;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateTask3;

        private IfElseBranchActivity ifElseBranchActivity42;

        private IfElseBranchActivity ifElseBranchActivity41;

        private IfElseActivity ifElseActivity1;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onTaskCreated3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity139;

        private SequenceActivity sequenceActivity88;

        private SequenceActivity sequenceActivity87;

        private SequenceActivity sequenceActivity86;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onexpeditedDGMReviewTaskChanged;

        private ConditionedActivityGroup conditionedActivityGroup3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity138;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask expeditedDGMReviewTaskCompleted;

        private WhileActivity whileDGMReviewTaskNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity137;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType expeditedDGMReviewTask;

        private SequenceActivity sequenceActivity85;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity136;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity148;

        private DelayActivity delayActivity17;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity147;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity146;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged6;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateTask4;

        private IfElseBranchActivity ifElseBranchActivity44;

        private IfElseBranchActivity ifElseBranchActivity43;

        private IfElseActivity ifElseActivity17;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onTaskCreated4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity145;

        private SequenceActivity sequenceActivity92;

        private SequenceActivity sequenceActivity91;

        private SequenceActivity sequenceActivity90;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onExpeditedCBSSReviewTaskChanged;

        private ConditionedActivityGroup conditionedActivityGroup4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity144;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask expeditedCBSSReviewTaskCompleted;

        private WhileActivity whileCBSSReviewTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity143;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType expeditedCBSSReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity150;

        private SequenceActivity sequenceActivity89;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity149;

        private IfElseBranchActivity ifExpedited;

        private IfElseBranchActivity ifNormal;

        private IfElseActivity ifElseExpedited;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity135;

        private DelayActivity delayActivity15;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity134;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity133;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged3;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateTask2;

        private CodeActivity codeActivity2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity132;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity126;

        private DelayActivity delayActivity14;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity125;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity124;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged2;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateTask1;

        private CodeActivity codeActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity123;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity117;

        private DelayActivity delayActivity13;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity116;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity115;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser4TaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask adHocUser4TaskUpdated;

        private CodeActivity codeAdHocUser4reviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity114;

        private IfElseBranchActivity ifElseBranchActivity36;

        private IfElseBranchActivity ifElseBranchActivity35;

        private IfElseBranchActivity ifElseBranchActivity32;

        private IfElseBranchActivity ifElseBranchActivity31;

        private IfElseBranchActivity adHocUser4TaskIsNOTOverdue;

        private IfElseBranchActivity adHocUser4TaskISOverdue;

        private IfElseActivity ifElseActivity16;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onTaskCreated2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity131;

        private IfElseActivity ifElseActivity15;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onTaskCreated1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity122;

        private IfElseActivity ifElseActivity14;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAdHocUser4ReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity112;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity108;

        private DelayActivity delayActivity12;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity107;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity106;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser3ReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask adHocUser3TaskUpdated;

        private CodeActivity codeAdHocUser3reviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity105;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity99;

        private DelayActivity delayActivity11;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity98;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity97;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser2ReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask adHocUser2TaskUpdated;

        private CodeActivity codeAdHocUser2reviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity96;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity90;

        private DelayActivity delayActivity10;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity89;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity88;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser1ReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask adHocUser1TaskUpdated;

        private CodeActivity codeAdHocUser1reviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity87;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity81;

        private DelayActivity delayActivity9;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity80;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity79;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMPoliceReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmPoliceReviewTaskUpdated;

        private CodeActivity codeAGMPoliceReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity78;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity72;

        private DelayActivity delayActivity8;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity71;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity70;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMCommunicationsReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmCommunicationsReviewTaskUpdated;

        private CodeActivity codeAGMCommunicationsReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity69;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity63;

        private DelayActivity delayActivity7;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity62;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity61;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMAuditReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmAuditReviewTaskUpdate;

        private CodeActivity codeAGMAuditReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity60;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity54;

        private DelayActivity delayActivity6;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity53;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity52;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMContractsReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmContractsReviewTaskUpdated;

        private CodeActivity codeAGMContractsReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity51;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity45;

        private DelayActivity delayActivity5;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity44;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity43;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMLegalReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmLegalReviewTaskUpdate;

        private CodeActivity codeAGMLegalReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity42;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity36;

        private DelayActivity delayActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity35;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity34;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMSafetyReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmSafetyReviewTaskUpdate;

        private CodeActivity codeAGMSafetyReviewExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity33;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity27;

        private DelayActivity delayActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity26;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity25;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMHumanResourcesTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmHumanResourcesTaskUpdate;

        private CodeActivity codeAGMHumanResourcesTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity24;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity18;

        private DelayActivity delayActivity2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity17;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity16;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onagmPlanningReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmPlanningReviewTaskUpdate;

        private CodeActivity codeAGMPlanningReviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity15;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity9;

        private DelayActivity delayActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity8;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity7;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMITReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmITReviewTaskUpdate;

        private CodeActivity codeAGMITReviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity6;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewDelayEnd;

        private DelayActivity delayActivityForAGMFinanceReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewDelayStart;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewTaskMarkedExpired;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMFinanceReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask agmFinanceReviewTaskUpdate;

        private CodeActivity codeAGMFinanceReviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewTaskExpired;

        private SequenceActivity sequenceActivity82;

        private SequenceActivity sequenceActivity81;

        private SequenceActivity sequenceActivity80;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMRailOperationsReviewTaskChanged;

        private SequenceActivity sequenceActivity79;

        private SequenceActivity sequenceActivity78;

        private SequenceActivity sequenceActivity77;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMBusOperationsReviewTaskChanged;

        private SequenceActivity sequenceActivity76;

        private SequenceActivity sequenceActivity75;

        private SequenceActivity sequenceActivity74;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser4TaskChanged;

        private IfElseBranchActivity adHocUser3TaskIsNOTOverdue;

        private IfElseBranchActivity adHocUser3TaskISOverdue;

        private IfElseBranchActivity adHocUser2TaskIsNOTOverdue;

        private IfElseBranchActivity adHocUser2TaskISOverdue;

        private IfElseBranchActivity adHocUser1TaskIsNOTOverdue;

        private IfElseBranchActivity adHocUser1TaskISOverdue;

        private IfElseBranchActivity agmPoliceReviewIsNOTOverdue;

        private IfElseBranchActivity agmPoliceReviewISOverdue;

        private IfElseBranchActivity agmCommunicationsIsNOTOverdue;

        private IfElseBranchActivity agmCommunicationsReviewISOverdue;

        private IfElseBranchActivity agmAuditReviewTaskIsNOTOverdue;

        private IfElseBranchActivity agmAuditReviewTaskISOverdue;

        private IfElseBranchActivity agmContractsReviewIsNOTOverdue;

        private IfElseBranchActivity agmContractsReviewISOverdue;

        private IfElseBranchActivity ifElseBranchActivity15;

        private IfElseBranchActivity agmLegalReviewTaskIsOverdue;

        private IfElseBranchActivity agmSafetyReviewTaskIsNotOverdue;

        private IfElseBranchActivity agmSafetyReviewTaskIsOverdue;

        private IfElseBranchActivity agmHumanResourcesTaskIsNOTOverdue;

        private IfElseBranchActivity agmHumanResourcesTaskIsOverdue;

        private IfElseBranchActivity agmPlanningReviewTaskIsNOTOverdue;

        private IfElseBranchActivity agmPlanningReviewTaskIsOverdue;

        private IfElseBranchActivity agmITReviewTaskIsNOTOverdue;

        private IfElseBranchActivity agmITReviewTaskIsOverdue;

        private IfElseBranchActivity agmFinanceReviewTaskIsNotOverdue;

        private IfElseBranchActivity agmFinanceReviewTaskIsOverdue;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity130;

        private ConditionedActivityGroup conditionedActivityGroup2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity129;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmRailOperationsReviewTaskCompleted;

        private WhileActivity whileAGMRailOperationsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity128;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmRailOperationsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity127;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity121;

        private ConditionedActivityGroup conditionedActivityGroup1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity120;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmBusOperationsReviewTaskCompleted;

        private WhileActivity whileAGMBusOperationsReviewTaskNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity119;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmBusOperationsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity118;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity111;

        private ConditionedActivityGroup CAGforAdHocUser4ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity113;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask adHocUser4ReviewTaskCompleted;

        private WhileActivity whileAdHocUser4ReviewTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity110;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType adHocUser4ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity109;

        private IfElseActivity ifElseActivity13;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAdHocUser3ReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity103;

        private IfElseActivity ifElseActivity12;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAdHocUser2ReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity94;

        private IfElseActivity ifElseActivity11;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAdhocUser1TaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity85;

        private IfElseActivity ifElseActivity10;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMPoliceTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity76;

        private IfElseActivity ifElseActivity8;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMCommunicationsReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity67;

        private IfElseActivity ifElseActivity9;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMAuditReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity58;

        private IfElseActivity ifElseActivity6;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMContractsReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity49;

        private IfElseActivity ifElseActivity7;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMLegalReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity40;

        private IfElseActivity ifElseActivity4;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMSafetyReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity31;

        private IfElseActivity ifElseActivity5;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMHumanResourcesReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity22;

        private IfElseActivity ifElseActivity3;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMPlanningReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity13;

        private IfElseActivity ifElseActivity2;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMITReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity4;

        private IfElseActivity ifAGMReviewTaskOverdue;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onAGMFinanceReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewTaskCreatedInSequence;

        private IfElseBranchActivity ifElseBranchActivity34;

        private IfElseBranchActivity ifElseBranchActivity33;

        private IfElseBranchActivity ifElseBranchActivity30;

        private IfElseBranchActivity ifElseBranchActivity29;

        private IfElseBranchActivity ifElseBranchActivity28;

        private IfElseBranchActivity ifElseBranchActivity27;

        private SequenceActivity sequenceActivity73;

        private SequenceActivity sequenceActivity72;

        private SequenceActivity sequenceActivity71;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser3TaskChanged;

        private SequenceActivity sequenceActivity70;

        private SequenceActivity sequenceActivity69;

        private SequenceActivity sequenceActivity68;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser2ReviewTaskChanged;

        private SequenceActivity sequenceActivity67;

        private SequenceActivity sequenceActivity66;

        private SequenceActivity sequenceActivity65;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAdHocUser1ReviewTaskChanged;

        private SequenceActivity sequenceActivity64;

        private SequenceActivity sequenceActivity63;

        private SequenceActivity sequenceActivity62;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMPoliceReviewTaskChanged;

        private SequenceActivity sequenceActivity61;

        private SequenceActivity sequenceActivity60;

        private SequenceActivity sequenceActivity59;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMCommunicationsReviewTaskChanged;

        private SequenceActivity sequenceActivity58;

        private SequenceActivity sequenceActivity57;

        private SequenceActivity sequenceActivity56;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMAuditReviewTaskChanged;

        private SequenceActivity sequenceActivity55;

        private SequenceActivity sequenceActivity54;

        private SequenceActivity sequenceActivity53;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMContractsReviewTaskChanged;

        private SequenceActivity sequenceActivity52;

        private SequenceActivity sequenceActivity51;

        private SequenceActivity sequenceActivity50;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMLegalReviewTaskChanged;

        private SequenceActivity sequenceActivity49;

        private SequenceActivity sequenceActivity48;

        private SequenceActivity sequenceActivity47;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMSafetyReviewTaskChanged;

        private SequenceActivity sequenceActivity46;

        private SequenceActivity sequenceActivity45;

        private SequenceActivity sequenceActivity44;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMHumanResourcesReviewTaskChanged;

        private SequenceActivity sequenceActivity43;

        private SequenceActivity sequenceActivity42;

        private SequenceActivity sequenceActivity41;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMPlanningTaskChanged;

        private SequenceActivity sequenceActivity40;

        private SequenceActivity sequenceActivity39;

        private SequenceActivity sequenceActivity38;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMITReviewTaskChanged;

        private SequenceActivity agmFinanceReviewDueDateMonitorSequence;

        private SequenceActivity agmReviewTaskCompletedSequence;

        private SequenceActivity agmReviewTaskCreatedSequence;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMFinanceReviewTaskChanged;

        private IfElseActivity ifElseAGMRailOperationsSelected;

        private IfElseActivity ifElseAGMBusOperationsSelected;

        private IfElseActivity ifElseAdHocUser4Selected;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity102;

        private ConditionedActivityGroup CAGforAdHocUser3ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity104;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask adHocUser3ReviewTaskCompleted;

        private WhileActivity whileAdHocUser3ReviewTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity101;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType adHocUser3ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity100;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity93;

        private ConditionedActivityGroup CAGforAdHocUser2ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity95;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask adHocUser2ReviewTaskCompleted;

        private WhileActivity whileAdHocUser2ReviewTaskNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity92;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType adHocUser2ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity91;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity84;

        private ConditionedActivityGroup CAGforAdHocUser1ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity86;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask adHocUser1ReviewTaskCompleted;

        private WhileActivity whileAdhocUser1ReviewTaskIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity83;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType adHocUser1ReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity82;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity75;

        private ConditionedActivityGroup CAGforAGMPoliceReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity77;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmPoliceReviewTaskCompleted;

        private WhileActivity whileAGMPoliceReviewTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity74;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmPoliceReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity73;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity66;

        private ConditionedActivityGroup CAGforAGMCommunicationsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity68;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmCommunicationsTaskCompleted;

        private WhileActivity whileAGMCommunicationsTaskIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity65;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmCommunicationsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity64;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity57;

        private ConditionedActivityGroup CAGforAGMAuditReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity59;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmAuditReviewTaskCompleted;

        private WhileActivity whileAGMAuditReviewTaskIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity56;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmAuditReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity55;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity48;

        private ConditionedActivityGroup CAGforAGMContractsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity50;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmContractsReviewTaskCompleted;

        private WhileActivity whileAGMContractsReviewIsNOTComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity47;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmContractsReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity46;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity39;

        private ConditionedActivityGroup CAGforAGMLegalReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity41;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmLegalReviewTaskCompleted;

        private WhileActivity whileAGMLegalReviewIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity38;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmLegalReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity37;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity30;

        private ConditionedActivityGroup CAGForSafetyReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity32;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmSafetyReviewTaskCompleted;

        private WhileActivity whileAGMSafetyReviewIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity29;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmSafetyReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity28;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity21;

        private ConditionedActivityGroup CAGForAGMHumanResourcesReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity23;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmHumanResourcesReviewTaskCompleted;

        private WhileActivity whileAGMHumanResourcesTaskNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity20;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmHumanResourcesReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity19;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity12;

        private ConditionedActivityGroup CAGForAGMPlanningReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity14;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmPlanningReviewTaskCompleted;

        private WhileActivity whileAGMPlanningReviewTaskNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity11;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmPlanningReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity10;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity3;

        private ConditionedActivityGroup CAGforAGM_ITReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity5;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmITReviewTaskCompleted;

        private WhileActivity whileAGMITReviewIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity2;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmITReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceNotSelected;

        private ConditionedActivityGroup CAGforAGMFinanceReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask agmFinanceReviewTaskCompleted;

        private WhileActivity whileAGMFinanceReviewIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType agmFinanceReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAGMFinanceSelected;

        private SequenceActivity sequenceActivity37;

        private SequenceActivity sequenceActivity36;

        private SequenceActivity sequenceActivity35;

        private SequenceActivity sequenceActivity34;

        private IfElseBranchActivity ifElseBranchActivity26;

        private IfElseBranchActivity ifElseBranchActivity25;

        private IfElseBranchActivity ifElseBranchActivity24;

        private IfElseBranchActivity ifElseBranchActivity23;

        private IfElseBranchActivity ifElseBranchActivity22;

        private IfElseBranchActivity ifElseBranchActivity21;

        private IfElseBranchActivity ifElseBranchActivity20;

        private IfElseBranchActivity ifElseBranchActivity19;

        private IfElseBranchActivity ifElseBranchActivity16;

        private IfElseBranchActivity ifElseBranchActivity14;

        private IfElseBranchActivity ifElseBranchActivity18;

        private IfElseBranchActivity ifElseBranchActivity17;

        private IfElseBranchActivity ifElseBranchActivity11;

        private IfElseBranchActivity ifElseBranchActivity10;

        private IfElseBranchActivity ifElseBranchActivity13;

        private IfElseBranchActivity ifElseBranchActivity12;

        private IfElseBranchActivity ifElseBranchActivity7;

        private IfElseBranchActivity ifElseBranchActivity6;

        private IfElseBranchActivity ifElseBranchActivity9;

        private IfElseBranchActivity ifElseBranchActivity8;

        private IfElseBranchActivity ifElseBranchActivity5;

        private IfElseBranchActivity ifElseBranchActivity4;

        private IfElseBranchActivity ifElseBranchActivity3;

        private IfElseBranchActivity ifElseBranchActivity1;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity ifReviewRequired;

        private ParallelActivity parallelActivity17;

        private ParallelActivity parallelActivity16;

        private IfElseActivity ifElseAdHocUser3Selected;

        private IfElseActivity ifElseAdHocUser2Selected;

        private IfElseActivity ifElseAdHocUser1Selected;

        private IfElseActivity ifElseAGMPoliceSelected;

        private IfElseActivity ifElseAGMCommunicationsSelected;

        private IfElseActivity ifElseAGMAuditSelected;

        private IfElseActivity ifElseAGMContractsSelected;

        private IfElseActivity ifElseAGMLegalIsSelected;

        private IfElseActivity ifElseAGMSafetySelected;

        private IfElseActivity ifElseAGMHumanResourcesReviewRequired;

        private IfElseActivity ifElseAGMPlanningReviewRequired;

        private IfElseActivity ifElseAGM_ITReviewRequired;

        private IfElseActivity ifElseAGMFinanceReviewRequired;

        private SequenceActivity sequenceActivity33;

        private SequenceActivity sequenceActivity32;

        private SequenceActivity sequenceActivity31;

        private SequenceActivity sequenceActivity30;

        private SequenceActivity sequenceActivity29;

        private SequenceActivity sequenceActivity28;

        private SequenceActivity sequenceActivity27;

        private SequenceActivity sequenceActivity26;

        private SequenceActivity sequenceActivity24;

        private SequenceActivity sequenceActivity23;

        private SequenceActivity sequenceActivity22;

        private SequenceActivity sequenceActivity21;

        private SequenceActivity sequenceActivity20;

        private SequenceActivity sequenceActivity19;

        private SequenceActivity sequenceActivity18;

        private SequenceActivity sequenceActivity17;

        private ParallelActivity parallelActivity15;

        private ParallelActivity parallelActivity14;

        private ParallelActivity parallelActivity13;

        private ParallelActivity parallelActivity12;

        private ParallelActivity parallelActivity11;

        private ParallelActivity parallelActivity10;

        private ParallelActivity parallelActivity9;

        private ParallelActivity parallelActivity8;

        private SequenceActivity sequenceActivity16;

        private SequenceActivity sequenceActivity15;

        private SequenceActivity sequenceActivity14;

        private SequenceActivity sequenceActivity13;

        private SequenceActivity sequenceActivity12;

        private SequenceActivity sequenceActivity11;

        private SequenceActivity sequenceActivity10;

        private SequenceActivity sequenceActivity9;

        private ParallelActivity parallelActivity7;

        private ParallelActivity parallelActivity6;

        private ParallelActivity parallelActivity5;

        private ParallelActivity parallelActivity4;

        private SequenceActivity sequenceActivity8;

        private SequenceActivity sequenceActivity7;

        private SequenceActivity sequenceActivity6;

        private SequenceActivity sequenceActivity5;

        private ParallelActivity parallelActivity3;

        private ParallelActivity parallelActivity2;

        private SequenceActivity sequenceActivity4;

        private SequenceActivity sequenceActivity3;

        private ParallelActivity parallelActivity1;

        private IfElseBranchActivity ifElseCBSSNotSelected;

        private IfElseBranchActivity ifElseCBSSSelected;

        private IfElseBranchActivity ifElseDGMNOTSelected;

        private IfElseBranchActivity ifElseDGMSelected;

        private IfElseActivity ifElseExpeditedCBSS;

        private IfElseActivity ifElseExpeditedDGM;

        private SequenceActivity sequenceActivity84;

        private SequenceActivity sequenceActivity83;

        private ParallelActivity parallelActivity18;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logWorkflowCompleted;

        private SequenceActivity sequenceActivity25;

        private CodeActivity codeSetAgendaStatusToPublished;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDocSetCopied;

        private CodeActivity codeCopyDocSetToBoard;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDGMReviewTaskDelayAwaken;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logBeforeDGMReviewTaskDelay;

        private WhileActivity whileGMApproveTaskIsNotApproved;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logGMApproveTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask GMApproveTaskComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logGMApproveTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType GMApproveTask;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeSubmtToGMApprovalTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logSubmitToGMApprovalTaskComplete;

        private CodeActivity codeSetAgendaStatusToSubmittedForGMApproval;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onSubmitForGMApprovalTaskChanged;

        private WhileActivity whileSubmitToGMApprovalTaskIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logGMApprovalTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAgendaStatusSetToDGMReviewCompleted;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType SubmitForGMApprovalTask;

        private DelayActivity delaySPSSReviewTaskIsDueCheck;

        private DelayActivity delayAGMApproveTaskIsDueCheck;

        private CodeActivity codeSetAgendaStatusToDGMApproved;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logSPSSReviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDGMReviewTaskExpired;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onSPSSReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onDGMReviewTaskUpdated;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateDGMReviewTaskToExpired;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateSPSSReviewTaskToExpired;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask SPSSReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask DGMReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logSPSSReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDGMReviewTaskCompleted;

        private IfElseBranchActivity SPSSReviewTaskIsNotOverdue;

        private IfElseBranchActivity SPSSReviewTaskIsOverdue;

        private IfElseBranchActivity DGMReviewTaskIsNotOverdue;

        private IfElseBranchActivity DGMReviewTaskIsOverDue;

        private IfElseActivity ifElseSPSSReviewTaskIsOverdue;

        private IfElseActivity ifElseDGMReviewTaskIsOverDue;

        private SequenceActivity sequenceSPSSReviewTaskDelay;

        private SequenceActivity sequenceDGMApproveTaskOverdue;

        private SequenceActivity sequenceSPSSReviewTaskCompleted;

        private SequenceActivity sequenceDGMReviewTaskCompleted;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onDGMReviewTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onSPSSReviewTaskChanged;

        private SequenceActivity sequenceSPSSReviewTaskCreated;

        private SequenceActivity sequenceDGMReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onSPSSReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logInSPSSReviewTaskCreatedSequence;

        private Microsoft.SharePoint.WorkflowActions.OnTaskCreated onDGMReviewTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logInDGMReviewTaskSequence;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType SPSSReviewTask;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType DGMApproveTask;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask SubmitForDGMApprovalTaskComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDGMApprovalTaskCompleted;

        private WhileActivity whileSPSSReviewTaskNotComplted;

        private ConditionedActivityGroup CAGForSPSSReviewTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logSPSSReviewTaskCreated;

        private WhileActivity whileAGMReviewTaskNotCompleted;

        private ConditionedActivityGroup CAGForDGMApproveTask;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logDGMReviewTaskCreated;

        private WhileActivity whileDGMApprovalTaskIncomplete;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onSubmitForDGMApprovalTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logSubmitForDGMApprovalTaskCreated;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logAgendaStatusChangedToStakeHolderReviewCompleted;

        private SequenceActivity sequenceActivity2;

        private SequenceActivity sequenceActivity1;

        private ParallelActivity parallelDGMandSPSSApproval;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType SubmitForDGMandSPSSReviewTask;

        private CodeActivity codeSetAgendaStatusToStakeHolderReviewsComplete;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logStatusForAgendaChanged;

        private CodeActivity codeSetAgendaStatusToPublishedForReview;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated;





















































































































































































































































































































































































































































































































































































































































































































































































































































































































































    }
}
