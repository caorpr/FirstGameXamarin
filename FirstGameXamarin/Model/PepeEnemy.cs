using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FirstGameXamarin.View;

namespace FirstGameXamarin
{
	public class PepeEnemy
	{
		


		// Animation representing the enemy
		public Animation PepeAnimation;

		// The position of the enemy ship relative to the top left corner of thescreen
		public Vector2 Position;

		// The state of the Enemy Ship
		public bool PepeActive;

		// The hit points of the enemy, if this goes to zero the enemy dies
		public int PepeHealth;

		// The amount of damage the enemy inflicts on the player ship
		public int PepeDamage;

		// The amount of score the enemy will give to the player
		public int Value;

		// Get the width of the enemy ship
		public int PepeWidth 
		{
			get { return PepeAnimation.FrameWidth; } 
		}

		// Get the height of the enemy ship
		public int PepeHeight 
		{
			get { return PepeAnimation.FrameHeight; } 
		}

		// The speed at which the enemy moves
		float pepeEnemyMoveSpeed;


		public void Initialize(Animation animation,Vector2 position)
		{
			// Load the enemy ship texture
			PepeAnimation = animation;

			// Set the position of the enemy
			Position = position;

			// We initialize the enemy to be active so it will be update in the game
			PepeActive = true;


			// Set the health of the enemy
			PepeHealth = 100;

			// Set the amount of damage the enemy can do
			PepeDamage = 100;

			// Set how fast the enemy moves
			pepeEnemyMoveSpeed = 1f;


			// Set the score value of the enemy
			Value = 1000;
		}


		public void Update(GameTime gameTime)
		{
			// The enemy always moves to the left so decrement it's xposition
			Position.X -= pepeEnemyMoveSpeed;

			// Update the position of the Animation
			PepeAnimation.Position = Position;

			// Update Animation
			PepeAnimation.Update(gameTime);

			// If the enemy is past the screen or its health reaches 0 then deactivateit
			if (Position.X < -PepeWidth || PepeHealth <= 0)
			{
				// By setting the Active flag to false, the game will remove this objet fromthe
				// active game list
				PepeActive = false;
			}
		}



		public void Draw(SpriteBatch spriteBatch)
		{
			// Draw the animation
			PepeAnimation.Draw(spriteBatch);
		}







	}
}


