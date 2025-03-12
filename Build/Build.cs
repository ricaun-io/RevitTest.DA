using Nuke.Common;
using Nuke.Common.Execution;
using ricaun.Nuke;
using ricaun.Nuke.Components;

class Build : NukeBuild, IPublish, ITest
{
    string IHazMainProject.MainName => "RevitTest.DA.Samples";
    string ITest.TestProjectName => "RevitTest.DA.Samples";
    public static int Main() => Execute<Build>(x => x.From<IPublish>().Build);
}
