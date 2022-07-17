using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary.Models;

namespace BattleshipLiteLibrary
{
    public static class GameLogic   
    {
        public static void InitializeShotGrid(PlayerInfoModel model)
        {
            List<string> letters = new()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new()
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }

        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        { 
            GridSpotModel spot = new()
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }
        
        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            bool output = false;
            
            (string locationLetter, int locationNumber) = SplitLocationIntoLetterAndNumber(location);

            bool isValidLocation = ValidateGridLocation(model, locationLetter, locationNumber);
            bool isSpotOpen = ValidateShipLocation(model, locationLetter, locationNumber);

            if (isValidLocation && isSpotOpen)
            {
                model.ShipLocations.Add(new GridSpotModel
                {
                    SpotLetter = locationLetter.ToUpper(),
                    SpotNumber = locationNumber,
                    Status = GridSpotStatus.Ship
                });

                output = true;
            }
            return output;
        }

        private static bool ValidateGridLocation(PlayerInfoModel model, string locationLetter, int locationNumber)
        {
            bool isValidLocation = false;

            foreach (var ship in model.ShotGrid)
            {
                if (ship.SpotLetter == locationLetter.ToUpper() && ship.SpotNumber == locationNumber)
                {
                    isValidLocation = true;
                }
            }

            return isValidLocation;
        }

        private static bool ValidateShipLocation(PlayerInfoModel model, string locationLetter, int locationNumber)
        {
            bool isValidLocation = true;

            foreach (var ship in model.ShipLocations)
            {
                if (ship.SpotLetter == locationLetter.ToUpper() && ship.SpotNumber == locationNumber)
                {
                    isValidLocation = false;
                }
            }

            return isValidLocation;
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isActive = true;
                }
            }

            return isActive;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    shotCount += 1;
                }
            }

            return shotCount;
        }

        public static (string locationLetter, int locationNumber) SplitLocationIntoLetterAndNumber(string location)
        {
            string locationLetter = "";
            int locationNumber = 0;

            if (location.Length != 2)
            {
                throw new ArgumentException("This was an invalid location type.", "location");
            }
            
            char[] locationArray = location.ToArray();

            locationLetter = locationArray[0].ToString();
            locationNumber = int.Parse(locationArray[1].ToString());

            return (locationLetter, locationNumber);
        }

        public static bool ValidateShot(PlayerInfoModel player, string shotLetter, int shotNumber)
        {
            bool isValidShot = false;

            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == shotLetter.ToUpper() && gridSpot.SpotNumber == shotNumber)
                {
                    if (gridSpot.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }

            return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string shotLetter, int shotNumber)
        {
            bool isAHit = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == shotLetter.ToUpper() && ship.SpotNumber == shotNumber)
                {
                    isAHit = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }

            return isAHit;
        }

        public static void MarkShotResult(PlayerInfoModel player, string shotLetter, int shotNumber, bool isAHit)
        {
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == shotLetter.ToUpper() && gridSpot.SpotNumber == shotNumber)
                {
                    if (isAHit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
