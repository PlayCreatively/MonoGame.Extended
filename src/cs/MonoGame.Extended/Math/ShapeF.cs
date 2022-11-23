using Microsoft.Xna.Framework;

namespace MonoGame.Extended
{
    /// <summary>
    ///     Base class for shapes.
    /// </summary>
    /// <remakarks>
    ///     Created to allow checking intersection between shapes of different types.
    /// </remakarks>
    public interface IShapeF
    {
        /// <summary>
        /// Gets or sets the position of the shape.
        /// </summary>
        Point2 Position { get; set; }
        Vector2 HalfExtents { get; }
        float HalfExtentsX { get; }
        float HalfExtentsY { get; }
    }

}
