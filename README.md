# LQC
LQC is a server project for creating hash blocks that can be used as tasks to get rewards.

# Info
The server uses a modification of the VANGA1811 - VANGA1811X algorithm to create tasks for users. The built - in service-FZW (Frozen Wallets), which guarantees the safe transfer of funds over the network, is responsible for storing and operating the data of users ' wallets. For greater security, the data about the user's wallets and transfers are stored in the database under his own hash, only the same user can get this data back, no exceptions. Receiving a block reward is controlled by multi-factor authentication, which adds additional protection.
