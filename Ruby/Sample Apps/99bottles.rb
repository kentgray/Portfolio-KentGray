bottle = 100
sing = ' bottles of beer on the wall. '
beer = 'bottles of beer! You take one down, pass it around and '

while bottle > 1
    puts (bottle-1).to_s + sing + (bottle-1).to_s + ' ' + beer + (bottle-2).to_s + sing

    bottle = (bottle-1)
end

puts 'Go Join AA Immediately!'
