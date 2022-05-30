shader_type canvas_item;

uniform float height = 5.00;
uniform float speed = 5.00;
uniform float frequency = 5.00;

void vertex(){
	VERTEX.y += height * sin((frequency * UV.x) + sin(speed * TIME));
}
