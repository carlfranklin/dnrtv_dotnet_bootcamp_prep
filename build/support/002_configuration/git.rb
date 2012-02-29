configs ={
  :git => {
    :user => "developwithpassion",
    :remotes => potentially_change("remotes",__FILE__),
    :repo => 'dnrtv_dotnet_bootcamp_prep' 
  }
}
configatron.configure_from_hash(configs)
