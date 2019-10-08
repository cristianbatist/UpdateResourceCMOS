//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpdateManpowerKOUsers.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class PWA_TasksForBP
    {
        public string PK { get; set; }
        public Nullable<System.Guid> TaskUID { get; set; }
        public string ProjectName { get; set; }
        public Nullable<short> ProjectPercentCompleted { get; set; }
        public Nullable<System.Guid> TaskParentUID { get; set; }
        public Nullable<System.Guid> ProjectUID { get; set; }
        public string TaskName { get; set; }
        public Nullable<bool> TaskIsProjectSummary { get; set; }
        public Nullable<bool> TaskIsCritical { get; set; }
        public Nullable<bool> TaskIsSummary { get; set; }
        public Nullable<decimal> TaskWork { get; set; }
        public Nullable<decimal> TaskActualWork { get; set; }
        public Nullable<decimal> TaskDurationVariance { get; set; }
        public Nullable<decimal> TaskStartVariance { get; set; }
        public Nullable<decimal> TaskFinishVariance { get; set; }
        public Nullable<decimal> TaskDuration { get; set; }
        public Nullable<decimal> TaskActualDuration { get; set; }
        public Nullable<System.DateTime> TaskStartDate { get; set; }
        public Nullable<System.DateTime> TaskFinishDate { get; set; }
        public Nullable<System.DateTime> TaskActualStartDate { get; set; }
        public Nullable<System.DateTime> TaskActualFinishDate { get; set; }
        public Nullable<short> TaskPercentCompleted { get; set; }
        public Nullable<short> TaskPercentWorkCompleted { get; set; }
        public Nullable<short> TaskPhysicalPercentCompleted { get; set; }
        public Nullable<short> TaskPriority { get; set; }
        public Nullable<System.DateTime> TaskDeadline { get; set; }
        public Nullable<bool> TaskIsExternal { get; set; }
        public Nullable<System.DateTime> TaskEarlyFinish { get; set; }
        public Nullable<System.DateTime> TaskEarlyStart { get; set; }
        public Nullable<System.DateTime> TaskLateFinish { get; set; }
        public Nullable<System.DateTime> TaskLateStart { get; set; }
        public Nullable<decimal> TaskWorkVariance { get; set; }
        public Nullable<bool> TaskIsActive { get; set; }
        public string TaskWBS { get; set; }
        public Nullable<decimal> TaskRegularWork { get; set; }
        public Nullable<decimal> TaskRemainingWork { get; set; }
        public Nullable<decimal> TaskActualRegularWork { get; set; }
        public Nullable<decimal> TaskRemainingRegularWork { get; set; }
        public Nullable<decimal> TaskRemainingDuration { get; set; }
        public Nullable<decimal> TaskBaseline0Work { get; set; }
        public Nullable<System.DateTime> TaskBaseline0StartDate { get; set; }
        public Nullable<System.DateTime> TaskBaseline0FinishDate { get; set; }
        public Nullable<decimal> TaskBaseline0Duration { get; set; }
        public Nullable<decimal> AssignmentWork { get; set; }
        public Nullable<decimal> AssignmentActualWork { get; set; }
        public Nullable<short> AssignmentPercentWorkCompleted { get; set; }
        public Nullable<System.DateTime> AssignmentStartDate { get; set; }
        public Nullable<System.DateTime> AssignmentFinishDate { get; set; }
        public Nullable<System.DateTime> AssignmentActualStartDate { get; set; }
        public Nullable<System.DateTime> AssignmentActualFinishDate { get; set; }
        public Nullable<decimal> AssignmentDelay { get; set; }
        public Nullable<decimal> AssignmentStartVariance { get; set; }
        public Nullable<decimal> AssignmentFinishVariance { get; set; }
        public Nullable<decimal> AssignmentWorkVariance { get; set; }
        public Nullable<decimal> AssignmentPeakUnits { get; set; }
        public Nullable<decimal> AssignmentRegularWork { get; set; }
        public Nullable<decimal> AssignmentRemainingWork { get; set; }
        public Nullable<decimal> AssignmentActualRegularWork { get; set; }
        public Nullable<decimal> AssignmentRemainingRegularWork { get; set; }
        public Nullable<decimal> AssignmentBaseline0Work { get; set; }
        public Nullable<System.DateTime> AssignmentBaseline0StartDate { get; set; }
        public Nullable<System.DateTime> AssignmentBaseline0FinishDate { get; set; }
        public string СДРес_Р { get; set; }
        public Nullable<System.Guid> ResourceUID { get; set; }
    }
}
