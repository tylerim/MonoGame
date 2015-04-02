using System;

namespace Microsoft.Xna.Framework.Graphics
{
    /// <summary>
    /// Helper class which ensures we only lookup a vertex 
    /// declaration for a particular type once.
    /// </summary>
    /// <typeparam name="T">A vertex structure which implements IVertexType.</typeparam>
    internal class VertexDeclarationCache<T>
        where T : struct, IVertexType
    {
        static private Lazy<VertexDeclaration> _cached = new Lazy<VertexDeclaration>(() => VertexDeclaration.FromType(typeof(T)));

        static public VertexDeclaration VertexDeclaration
        {
            get
            {
                return _cached.Value;
            }
        }
    }
}
