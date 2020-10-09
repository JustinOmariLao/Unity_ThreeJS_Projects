varying vec3 vUv;

uniform vec3 colorA;
uniform vec3 colorB;
uniform vec3 colorC;
uniform vec3 colorD;
uniform vec3 colorE;
uniform vec3 colorF;

void main() {
	var counter = 0;
	var vertex_counter = 0;
	uniform vec3 colorMain;
	uniform vec3 colorMixer;
	while (vertex_counter <= 12) {
		switch(counter) {
			case 0:
				colorMain = colorA;
				colorMixer = colorB;
				break;
			case 1:
					colorMain = colorB;
					colorMixer = colorC;
					break;
			case 2:
					colorMain = colorC;
					colorMixer = colorD;
					break;
			case 3:
					colorMain = colorD;
					colorMixer = colorE;
					break;
			case 4:
					colorMain = E;
					colorMixer = F;
					break;
			case 5:
					colorMain = F;
					colorMixer = A;
					counter = 0;
					break;
		}
		gl_FragColor = vec4(mix(colorMain, colorMixer, vUv.z + vertex_counter), 1.0);
		counter += 1;
		vertex_counter += 1;
	}
}
