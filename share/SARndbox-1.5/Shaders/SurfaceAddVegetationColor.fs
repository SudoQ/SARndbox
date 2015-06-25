/***********************************************************************
SurfaceAddVegetationColor - Shader fragment to add vegetation color
Simon Johansson 2015

This file is part of the Augmented Reality Sandbox (SARndbox).

The Augmented Reality Sandbox is free software; you can redistribute it
and/or modify it under the terms of the GNU General Public License as
published by the Free Software Foundation; either version 2 of the
License, or (at your option) any later version.

The Augmented Reality Sandbox is distributed in the hope that it will be
useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
General Public License for more details.

You should have received a copy of the GNU General Public License along
with the Augmented Reality Sandbox; if not, write to the Free Software
Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
***********************************************************************/

#extension GL_ARB_texture_rectangle : enable

/**************************
Vegetation shading function
***************************/
uniform sampler2DRect vegetationSampler;

varying vec2 waterLevelTexCoord; // Texture coordinate for water level and vegetation texture

void addVegetationColor(in vec2 fragCoord,inout vec4 baseColor) //FIXME fragCoord unused?
	{

	float veg = texture2DRect(vegetationSampler, waterLevelTexCoord).r; // Read vegetation value

	//vec4 color0 =		vec4(0.0/255.0, 	102/255.0, 		0.0, 1.0);
	//vec4 color1 =		vec4(64.0/255.0, 	140/255.0, 		0.0, 1.0); 
	//vec4 color2 =		vec4(128.0/255.0,	179/255.0, 		0.0, 1.0);
	//vec4 color3 =		vec4(191.0/255.0,	217/255.0, 		0.0, 1.0);
	//vec4 color4 =		vec4(255.0/255.0,	255.0/255.0,	0.0, 1.0);
	/*
	if(veg > 0.0){
		vec4 vegColor;
		if(veg < 0.2) {
			vegColor = color0;
		} else if (veg < 0.4) {
			vegColor = color1;
		} else if (veg < 0.6) {
			vegColor = color2;
		} else if (veg < 0.8) {
			vegColor = color3;
		} else if (veg < 1.0) {
			vegColor = color4;
		} else {
			vegColor = vec4(0.0, 0.0, 0.0, 0.0); 
		}
		baseColor=mix(baseColor, vegColor, 0.9);
	}
	*/
	/*
	if(veg > 0.0) {
		float r = 0.0;
		float g = veg;
		if (veg > 0.8) {
			r = 0.5;
		}
		g = veg*0.8 + 0.2;
		vec4 vegColor = vec4(r,g,0.0,1.0);
		baseColor=mix(baseColor, vegColor, 0.9);
	}
	*/
	// TODO Move to seperate color map
	vec4 vegColor;
	//vec4 color0 =		vec4(66.0/255.0, 	33.0/255.0, 	18.0/255.0, 1.0);
	//vec4 color1 =		vec4(159.0/255.0, 81.0/255.0, 	42.0/255.0, 1.0); 
	//vec4 color2 =		vec4(192.0/255.0,	163.0/255.0, 	69.0/255.0, 1.0);
	vec4 color0 =		vec4(253.0/255.0,	254.0/255.0, 	0.0, 1.0);
	vec4 color1 =		vec4(228.0/255.0,	238.0/255.0,	0.0, 1.0);
	vec4 color2 =		vec4(208.0/255.0,	233.0/255.0,	0.0, 1.0);
	vec4 color3 =		vec4(185.0/255.0,	207.0/255.0,	0.0, 1.0);
	vec4 color4 =		vec4(162.0/255.0,	192.0/255.0,	0.0, 1.0);
	vec4 color5 =		vec4(139.0/255.0,	176.0/255.0,	0.0, 1.0);
	vec4 color6 =		vec4(118.0/255.0,	158.0/255.0,	0.0, 1.0);
	vec4 color7 =		vec4(90.0/255.0,	142.0/255.0,	0.0, 1.0);
	vec4 color8 =		vec4(69.0/255.0,	128.0/255.0,	0.0, 1.0);
	vec4 color9 =		vec4(45.0/255.0,	112.0/255.0,	0.0, 1.0);
	vec4 color10 =	vec4(23.0/255.0,	97.0/255.0,	0.0, 1.0);
	vec4 color11 =	vec4(0.0/255.0,		82.0/255.0,	0.0, 1.0);
	if(veg > 0.0){
		if(veg <= 1.0/12.0){
				vegColor = color0;
		} else if(veg <= 2.0/12.0) {
				vegColor = color1;
		} else if(veg <= 3.0/12.0) {
				vegColor = color2;
		} else if(veg <= 4.0/12.0) {
				vegColor = color3;
		} else if(veg <= 5.0/12.0) {
				vegColor = color4;
		} else if(veg <= 6.0/12.0) {
				vegColor = color5;
		} else if(veg <= 7.0/12.0) {
				vegColor = color6;
		} else if(veg <= 8.0/12.0) {
				vegColor = color7;
		} else if(veg <= 9.0/12.0) {
				vegColor = color8;
		} else if(veg <= 10.0/12.0) {
				vegColor = color9;
		} else if(veg <= 11.0/12.0) {
				vegColor = color10;
		} else {
				vegColor = color11;
		}
		baseColor=mix(baseColor, vegColor, 0.8);
	}

	}
