puts 1.0 + 2.0
puts 2.0 * 3.0
puts 5.0 - 8.0
puts 9.0 / 2.0

puts 24*365 
puts 60 * 24 * 365 * 10
puts 60*24*365*31.5
puts 1246000000 /60/24/365

puts 2016%4
puts 2015%4


while (first % 4 == 0 and first % 100 != 0) or (first % 100 == 0 and first % 400 == 0)
    puts first.to_s
    first = first + 1
end


(last - first).times do |year|
if ((first.to_i - last.to_i).abs)%4 == 0
    puts (first.to_i - last.to_i).abs
    puts year.to_s
end
end


while first < last
    if (first % 4 == 0 and first % 100 != 0) or (first % 100 == 0 and first % 400 == 0)
    puts first.to_s
end
    first = first + 1
end

