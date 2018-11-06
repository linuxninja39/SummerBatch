using Summer.Batch.Core.Unity.Xml;

namespace Summer.Batch.Core.Configuration
{
    public interface IJobConfigurator
    {
        XmlJob GetXmlJob();
    }
}