# PUCSP 2D Top-Down Game Project

This repository contains the source code and assets for a 2D top-down game developed as part of a project at PUCSP (Pontifícia Universidade Católica de São Paulo).

![Game Screenshot](path_to_screenshot.png)

## Table of Contents

1. [Features](#features)
2. [Getting Started](#getting-started)
3. [Dependencies](#dependencies)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)

## Features

- **Sprites**: The game boasts a collection of detailed and well-designed sprites that represent different game entities.
  
- **Tiles**: Meticulously crafted tiles that make up the game world.
  
- **Player**: Control a character in the top-down world.
  
- **AI Entities**: The game has AI characters that are all children of a common base class. These AI characters exhibit different behaviors, making the gameplay more challenging and engaging.
  
- **State Machine**: Implemented a state machine for the AI to switch between various states and behaviors dynamically based on in-game situations.

## Getting Started

To get a local copy up and running, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your_username/pucsp-topdown-game.git
   cd pucsp-topdown-game
   ```

2. **Install Dependencies**:
   Follow the [Dependencies](#dependencies) section to install necessary dependencies.

3. **Run the Game**:
   ```bash
   # This is just an example. Actual run command might differ.
   python main.py
   ```

## Dependencies

List the specific dependencies for the project, for example:

- Python 3.8 or above
- Pygame 2.0.1

To install the dependencies:

```bash
pip install -r requirements.txt
```

## Usage

1. Use the arrow keys/W, A, S, D to move the player around.
2. Interact with the AI entities, observing their behaviors driven by the state machine.



## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

---

**Note**: Replace placeholders like `your_username` and `path_to_screenshot.png` with actual values. This README serves as a template, so be sure to adjust content accordingly for the specifics of your project.