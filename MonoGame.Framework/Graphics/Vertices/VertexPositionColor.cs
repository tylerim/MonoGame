using System;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Microsoft.Xna.Framework.Graphics
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VertexPositionColor : IVertexType
    {
        [DataMember] public Vector3 Position;

        [DataMember] public Color Color;

        public VertexPositionColor(Vector3 position, Color color)
        {
            this.Position = position;
            Color = color;
        }

        VertexDeclaration IVertexType.NewVertexDeclaration
        {
            get
            {
                return new VertexDeclaration(new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0), new VertexElement(12, VertexElementFormat.Color, VertexElementUsage.Color, 0));
            }
        }

        public override int GetHashCode()
        {
            // TODO: Fix gethashcode
            return 0;
        }

        public override string ToString()
        {
            return "{{Position:" + this.Position + " Color:" + this.Color + "}}";
        }

        public static bool operator ==(VertexPositionColor left, VertexPositionColor right)
        {
            return ((left.Color == right.Color) && (left.Position == right.Position));
        }

        public static bool operator !=(VertexPositionColor left, VertexPositionColor right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != base.GetType())
            {
                return false;
            }
            return (this == ((VertexPositionColor) obj));
        }
    }
}