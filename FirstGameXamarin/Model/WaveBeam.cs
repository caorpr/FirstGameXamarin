using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FirstGameXamarin.View;

namespace FirstGameXamarin
{
	public class WaveBeam
	{

		private float speed;


		public int Hurt;

		private bool active;
		public bool Active
		{
			get { return active; }
			set{ active = value; }
		} 


		private Animation waveBeamAnimation;
		public Animation WaveBeamAnimation
		{
			get{return waveBeamAnimation;}
			set{waveBeamAnimation = value;}
		}

		public Texture2D WaveBeamTexture;

		public Vector2 Position;


		public int Width
		{
			get { return waveBeamAnimation.FrameWidth; }
		}

		public int Height
		{
			get { return waveBeamAnimation.FrameHeight; }
		}


		// Initialize the player
		public void Initialize(Animation animation, Vector2 position)
		{
			waveBeamAnimation = animation;

			// Set the starting position of the player around the middle of the screen and to the back
			Position = position;

			// Set the player to be active
			Active = true;

			speed = .1f;

			Hurt = 3;

		}

		// Draw the player
		public void Draw(SpriteBatch spriteBatch)
		{
			waveBeamAnimation.Draw(spriteBatch);
		}




		// Update the player animation
		public void Update(GameTime gameTime)
		{


			waveBeamAnimation.Position.X += speed;

			waveBeamAnimation.Position.Y += (float)Math.Sin (waveBeamAnimation.Position.X * 3) * 15;



			waveBeamAnimation.Update(gameTime);
		}

	}
}

