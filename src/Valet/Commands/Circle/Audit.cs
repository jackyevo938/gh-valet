using System.CommandLine;

namespace Valet.Commands.Circle;

public class Audit : ContainerCommand
{
    public Audit(string[] args) : base(args)
    {
    }

    protected override string Name => "circle-ci";
    protected override string Description => "An audit will output a list of data used in a CircleCI instance.";

    private static readonly Option<FileInfo> ConfigFilePath = new("--config-file-path")
    {
        Description = "The file path corresponding to the CircleCI configuration file.",
        IsRequired = false,
    };

    protected override List<Option> Options => new()
    {
        Common.InstanceUrl,
        Common.AccessToken,
        Common.Organization,
        Common.SourceGitHubAccessToken,
        Common.SourceGitHubInstanceUrl,
        ConfigFilePath
    };
}