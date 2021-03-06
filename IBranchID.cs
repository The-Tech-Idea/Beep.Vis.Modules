using System;
using System.Collections.Generic;
using System.Text;
using TheTechIdea.Beep.Vis;

namespace BeepEnterprize.Vis.Module
{
    public interface IBranchID
    {
        string Name { get; set; }
        string BranchText { get; set; }
        int Level { get; set; }
        EnumPointType BranchType { get; set; }
        int BranchID { get; set; }
        string IconImageName { get; set; }
        string BranchStatus { get; set; }
        int ParentBranchID { get; set; }
        string BranchDescription { get; set; }
        string BranchClass { get; set; }
    }
}
