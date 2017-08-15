#!/bin/sh
set -e
echo "Change PList"

echo PList File: $1
echo Version: $2
echo Short Version: $3

echo PATH: $PATH

#keep this in order of actual plist for project
plistbuddy -c "Set CFBundleVersion $2” $1
plistbuddy -c "Set CFBundleShortVersionString $3” $1
