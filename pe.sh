#!/bin/bash

build() {
  csc -out:projecteuler.exe -recurse:*.cs
  echo 'finished compiling project!'
}

run() {
  mono projecteuler.exe $1
}

if [[ $1 == "build" ]]
then
  build 
fi

if [[ $1 == "run" ]]
then
  run $2
fi

if [[ -z $1 ]]
then
  echo 'tasks: build, run'
fi