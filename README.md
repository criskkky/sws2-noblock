<div align="center">

# [SwiftlyS2] NoBlock

[![GitHub Release](https://img.shields.io/github/v/release/criskkky/sws2-noblock?color=FFFFFF&style=flat-square)](https://github.com/criskkky/sws2-noblock/releases/latest)
[![GitHub Issues](https://img.shields.io/github/issues/criskkky/sws2-noblock?color=FF0000&style=flat-square)](https://github.com/criskkky/sws2-noblock/issues)
[![GitHub Downloads](https://img.shields.io/github/downloads/criskkky/sws2-noblock/total?color=blue&style=flat-square)](https://github.com/criskkky/sws2-noblock/releases)
[![GitHub Stars](https://img.shields.io/github/stars/criskkky/sws2-noblock?style=social)](https://github.com/criskkky/sws2-noblock/stargazers)<br/>
  <sub>Made with ❤️ by <a href="https://github.com/criskkky" rel="noopener noreferrer" target="_blank">criskkky</a></sub>
  <br/>
</div>

## Overview

Disable collision between all players. By default, CS2 only allows disabling collisions between players that are on the same team, but with this plugin, you can disable collisions between all players, regardless of their team.

## Download Shortcuts
<ul>
  <li>
    <code>📦</code>
    <strong>&nbspDownload Latest Plugin Version</strong> ⇢
    <a href="https://github.com/criskkky/sws2-noblock/releases/latest" target="_blank" rel="noopener noreferrer">Click Here</a>
  </li>
  <li>
    <code>⚙️</code>
    <strong>&nbspDownload Latest SwiftlyS2 Version</strong> ⇢
    <a href="https://github.com/swiftly-solution/swiftlys2/releases/latest" target="_blank" rel="noopener noreferrer">Click Here</a>
  </li>
</ul>

## Features
- **Disable Collisions**: Allows disabling collisions between all players, regardless of team affiliation.
- **Plug and Play**: No configuration required; works immediately after installation and applies to all players on load.

## Screenshots
> No screenshots available yet.

## Plugin Setup
> [!WARNING]
> Make sure you **have installed SwiftlyS2 Framework** before proceeding.

1. Download and extract the latest plugin version into your `swiftlys2/plugins` folder.
2. Ready!

## Backend Logic (How It Works)
1. The plugin detects all players on load and also hooks when new players spawn.
2. It sets the collision group of each player to 'Debris'.
3. As a result, all players can pass through each other without collision.

## Support and Feedback
Feel free to [open an issue](https://github.com/criskkky/sws2-noblock/issues/new/choose) for any bugs or feature requests. If it's all working fine, consider starring the repository to show your support!

## Contribution Guidelines
Contributions are welcome only if they align with the plugin's purpose. For major changes, please open an issue first to discuss what you would like to change.
