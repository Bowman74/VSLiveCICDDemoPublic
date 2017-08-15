echo restore packages
set -e

echo Solution Name : $1
echo Nuget Location : $2

mono $2 restore $1