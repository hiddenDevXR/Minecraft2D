#include "SFML-2.5.1/include/SFML/Graphics.hpp"
#include "SFML-2.5.1/include/SFML/Window.hpp"

int main(int argc, char *argv[])
{
	sf::RenderWindow window(sf::VideoMode(800, 600), "Proof of Concept!");
	sf::Font font;
	font.loadFromFile("Roman SD.ttf");
	sf::Text text("SFML works!", font);
	text.setCharacterSize(40);
	text.setFillColor(sf::Color::White);
	text.setStyle(sf::Text::Bold);
	text.setPosition(0,0);
	sf::Texture texture;
	texture.loadFromFile("bb.jpg");
	sf::Sprite sprite;
	sprite.setTexture(texture);
	sprite.setPosition(0,50);
	
  while (window.isOpen())
  {
		
    sf::Event event;

    while (window.pollEvent(event))
    {
      if (event.type == sf::Event::Closed) window.close();
    }

    window.clear();
    window.draw(text);
		window.draw(sprite);
    window.display();

  }

  return 0;
} 
