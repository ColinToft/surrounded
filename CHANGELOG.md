## 0.7.0 - 2019-08-09
### Added
- Dodge mode (player is unable to shoot balls)
- Invisible mode (player can only see balls close to them)
- Tutorials (separate tutorials for all game modes)
- New display resolution settings: framerate and VSync

### Changed
- Dynamically create squares and circles instead of drawing from sprites to improve graphics quality
- Manually calculate bouncing physics instead of relying on Unity’s built in physics, which was causing issues
- High scores screen is now two columns to fit all game modes

### Fixed
- Issue where the game would crash loading save data from previous versions
- Issue where slider wouldn’t go all the way to the sides of the bar
- Issue where game crashes when creating save file for the first time

## 0.6.0 - 2019-02-20
### Added
- Two-hit mode (balls take two-hits to be destroyed instead of one)
- Teleport mode (instead of bouncing, balls move off one side of the screen and reappear on the opposite side)
- Highscores screen (shows highscores in all game modes)

### Changed
- Made menus and game scale to work on all window sizes

### Fixed
- Issue that can cause a player to be killed by a ball they just shot
- Balls don’t correctly bounce off sides of screen after screen has been resized
- Balls are white for one frame before changing to the correct colour
- Options menu correctly saves quality, window size, and fullscreen settings

## 0.5.1 - 2019-01-28
### Added
- Game icon

### Fixed
- Small fixes to make sure game modes work as intended

## 0.5.0 - 2018-08-05
### Added
- Cluster mode (computer-spawned balls that collide form into groups)

### Changed
- Improved options menu (change graphics quality, window size, toggle fullscreen)

## 0.4.0 - 2018-07-27
### Added
- Hard mode (computer-spawned balls that collide don't dissapear)
- Easy mode (balls don't collide against the sides of the screen, instead they 
- Separate game mode menu to choose from Frozen, Easy, and Hard mode
- Pause menu

## 0.3.0 - 2018-07-19
### Added
- Frozen game mode (player is unable to move)
- Game Over Screen
- Credits Screen

### Changed
- Menu text changes colour
- Improved positioning of text in menu
- Centered text in options menu

## 0.2.0 - 2018-07-17
### Added
- A main menu (Play, Options, Credits, Save & Quit)
- Game over screen
- Credits screen
- Options menu to adjust music volume and reset highscores
- Music

## 0.1.0 - 2018-07-06
### Added
- Basic gameplay and score counter
