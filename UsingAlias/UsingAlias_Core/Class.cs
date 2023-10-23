
using ForWpf = ProjectReference;
using ForWinForms = System.Drawing;
using NameValuePair = (string Name, object? Value); //Context actions - use this type alias where possible

namespace UsingAlias_Core
{
    public class TreeChecker : ITreeProcessor<List<(string Name, object? Value)>> //Quick fixes - use type alias
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
        System.Security.Cryptography.DES des = System.Security.Cryptography.DES.Create(); //Context actions - Introduce type alias for 'System.Security.Cryptography.DES'
        //Quick fixes - use namespace alias
        public static ProjectReference.Point Convert(System.Drawing.Point point) => new ProjectReference.Point(point.X, point.Y);
    }
}
