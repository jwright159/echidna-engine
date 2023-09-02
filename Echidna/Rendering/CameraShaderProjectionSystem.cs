﻿using Echidna.Hierarchy;
using OpenTK.Mathematics;

namespace Echidna.Rendering;

public class CameraShaderProjectionSystem : System<Transform, Projection, CameraShaders>
{
	protected override void OnDrawEach(Transform transform, Projection projection, CameraShaders cameraShaders)
	{
		Matrix4 viewMatrix = transform.Transformation.Inverted();
		Matrix4 projectionMatrix = projection.ProjectionMatrix;
		foreach (Shader shader in cameraShaders.shaders)
		{
			shader.Bind();
			shader.SetMatrix4("view", viewMatrix);
			shader.SetMatrix4("projection", projectionMatrix);
		}
	}
}