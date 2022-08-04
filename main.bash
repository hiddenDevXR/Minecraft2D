clang++ -std=c++2a -LSFML-2.5.1/lib -lsfml-graphics -lsfml-window -lsfml-system *.cpp -o main
chmod 744 main
export LD_LIBRARY_PATH=SFML-2.5.1/lib
./main

#made by https://repl.it/@SPQR