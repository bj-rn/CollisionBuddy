using Stride.Core.Mathematics;

namespace CollisionBuddy
{
	public interface ICircle : ICollidable
	{
		Vector2 Pos { get; set; }

		float Radius { get; set; }

		float RadiusSquared { get; }
	}
}
