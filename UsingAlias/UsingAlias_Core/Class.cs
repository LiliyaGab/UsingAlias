
using ForWpf = ProjectReference;
using ForWinForms = System.Drawing;
using NameValuePair = (string Name, object? Value);

namespace UsingAlias_Core
{
    public class TreeChecker : ITreeProcessor<List<(string Name, object? Value)>> //use type alias
    {
        public bool IsProcessFinished(List<(string Name, object? Value)> context)
        {
            throw new NotImplementedException();
        }

        public void ProcessBeforeDescendants(INode element, List<(string Name, object? Value)> context)
        {
            throw new NotImplementedException();
        }

        public void ProcessAfterDescendants(INode element, List<(string Name, object? Value)> context)
        {
            throw new NotImplementedException();
        }
    }

    public interface ITreeProcessor<T>
    {
        bool IsProcessFinished(List<(string Name, object? Value)> context);
        void ProcessBeforeDescendants(INode element, List<(string Name, object? Value)> context);
        void ProcessAfterDescendants(INode element, List<(string Name, object? Value)> context);
    }

    public interface INode
    {
    }

    public class Converters
    {
        //use namespace alias
        public static ProjectReference.Point Convert(System.Drawing.Point point) => new ProjectReference.Point(point.X, point.Y);
    }
}
