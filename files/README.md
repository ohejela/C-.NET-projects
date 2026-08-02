# Gravity Runner  🚀

A side-scrolling obstacle-course game built in **C# Windows Forms**.

---

## 📁 Files

| File | Purpose |
|---|---|
| `GravityRunner.cs` | Complete game source (single file) |
| `GravityRunner.csproj` | .NET 6 project file |
| `player_run1.png` | Sprite – run frame 1 |
| `player_run2.png` | Sprite – run frame 2 |
| `player_jump.png` | Sprite – jump / airborne |
| `player_dead.png` | Sprite – death pose |

> **White background = transparency.**  
> The game calls `Bitmap.MakeTransparent(Color.White)` at load-time,
> followed by a pixel scan that removes AA-fringe near-white pixels.  
> If the PNG files are missing the game falls back to procedurally
> drawn sprites so it still runs with no assets.

---

## 🛠️ Building

### Prerequisites
- .NET 6 SDK (or later) with Windows Forms support  
  → https://dotnet.microsoft.com/download

### Steps
```bash
# 1. Put all 4 PNGs in the same folder as the .csproj
# 2. Build and run
cd GravityRunner
dotnet run
```

Or build a release binary:
```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

---

## 🎮 Controls

| Key | Action |
|---|---|
| **Space / ↑ / W** | Jump (press again in air for double-jump) |
| **P** | Pause / Resume |
| **Esc** | Return to Title screen |

---

## 🎲 Gameplay

- The runner moves forward automatically; the world scrolls toward you.
- Three hazard types appear randomly:
  - 🔺 **Spikes** – low, requires a basic jump
  - 🟩 **Block** – taller, jump over or double-jump
  - 🟡 **Low Bar** – wide horizontal bar, jump and clear the width
- Speed increases continuously – survive as long as possible!
- Score is displayed in the HUD together with your all-time best.

---

## 🏗️ Architecture (single file overview)

```
Program          – entry point
GameForm         – main Form: game loop (Timer → Update → Render)
  ├─ Physics     – gravity, variable jump (hold for floatier arc),
  │              – double-jump with visual burst particles
  ├─ Hazard      – position, kind, hit-box, procedural drawing
  ├─ BgLayer     – parallax city-scape rectangle layers
  ├─ Particle    – death burst & double-jump puff
  └─ GraphicsEx  – rounded-rectangle helper extension methods
```

---

## 🖼️ Sprite transparency workflow

```
PNG (white bg)
    │
    ▼
Bitmap.MakeTransparent(Color.White)   // exact white → alpha=0
    │
    ▼
Pixel scan: any (R,G,B) > 230        // AA fringe cleanup
    │
    ▼
DrawImage() renders cleanly on any background
```
