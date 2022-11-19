namespace MonoGame.Extended.Collisions
{
    /// <summary>
    /// An actor that can be collided with.
    /// </summary>
    public interface ICollisionActor
    {
        IShapeF Shape { get; }

        void OnCollision(CollisionEventArgs collisionInfo);
    }
}
