
using ForWpf = ProjectReference;
using ForWinForms = System.Drawing;
using NameValuePair = (string Name, object? Value); //Context actions - use this type alias where possible // TODO: negative cases
using ArrayAlias = ProjectReference.Point[]; // TODO: other types
//TODO: global usings ?
//using NameValuePair2 = (string Name, object? Value);

namespace UsingAlias_Core
{
	using NameValuePair = (string Name1, object? Value);
	using NameValuePair2 = (string Name, object? Value);
	using Point2 = ForWpf.Point;
	using Point = ForWinForms.Point;

	public class TreeChecker : ITreeProcessor<List<(string Name, object? Value)>> //Quick fixes - use type alias
	{
		private ProjectReference.Point[]? myPoint;

		public bool IsProcessFinished(List<(string Name, object Value)> context)
        {
            throw new NotImplementedException();
        }

        public void ProcessBeforeDescendants(INode element, List<(string Name2, object? Value)> context)
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
        void ProcessBeforeDescendants(INode element, List<(string Name2, object? Value)> context);
        void ProcessAfterDescendants(INode element, List<(string Name, object? Value)> context);
    }

    public interface INode
    {
    }

    public class Converters
    {
        System.Security.Cryptography.DES des = System.Security.Cryptography.DES.Create(); //Context actions - Introduce type alias for 'System.Security.Cryptography.DES'
        //Quick fixes - use namespace alias
        public static ProjectReference.Point Convert(Point point) => new Point2(point.X, point.Y);
        public static ProjectReference.Point Convert2(Point point) => new Point2(point.X, point.Y);
    }
}
