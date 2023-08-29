﻿namespace Echidna;

public class SwapBuffersSystem : System
{
	public SwapBuffersSystem() : base(typeof(Window)) { }
	
	public override void OnDraw()
	{
		foreach (Entity entity in Entities)
			entity.GetComponent<Window>().window.SwapBuffers();
	}
}